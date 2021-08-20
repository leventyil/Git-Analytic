using GitAnalytic.Helpers;
using GitAnalytic.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GitAnalytic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : Controller
    {

        [HttpPost]
        public async Task<PartialViewResult> Post()
        {
            ViewBag.nullTime = DateTimeOffset.ParseExact("1/1/0001 12:00:00 AM +00:00", "M/d/yyyy hh:mm:ss tt K", CultureInfo.InvariantCulture);

            using StreamReader r = new StreamReader("appsettings.json");          
            string json = r.ReadToEnd();
            var config = JsonConvert.DeserializeObject<Settings>(json);

            string userValue = Request.Form["User"].ToString();
            string repoValue = Request.Form["Repo"].ToString();

            foreach (var item in config.Info.Values)
            {
                bool isGithubRepo = ConfigHelper.IsGithubRepo(item.IsGithubRepo);

                if (userValue == item.IndexNumber)
                {                                            
                    if (isGithubRepo){ await GithubPullRequest(isGithubRepo, repoValue, userValue); return PartialView("_Post", ViewData); }
                    else{ await DevOpsPullRequest(isGithubRepo, repoValue, userValue); return PartialView("_PostDevOps", ViewData); }
                }
            }                                                                    
            return PartialView("_Post");
            
                                         
            async Task GithubPullRequest(bool isGithubRepo, string repoValue, string userValue)
            {
                using StreamReader r = new StreamReader("appsettings.json");
                string json = r.ReadToEnd();
                var config = JsonConvert.DeserializeObject<Settings>(json);

                foreach (var item in config.Info.Values)
                {
                    if (userValue == item.IndexNumber)
                    {
                        HttpClient httpClient = new HttpClient
                        {
                            BaseAddress = new Uri(Constants.GitHubGraphqlAddress)
                        };
                        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", item.Token);
                        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        httpClient.DefaultRequestHeaders.Add("User-Agent", "application");

                        var query = Work.GetPullRequestData(isGithubRepo, repoValue, item.UserOrganization, "");
                        var data = new StringContent(query, Encoding.UTF8, "application/json");
                        using var response = await httpClient.PostAsync("", data);
                        var responseString = await response.Content.ReadAsStringAsync();
                        var settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            MissingMemberHandling = MissingMemberHandling.Ignore
                        };
                        var responseObj = JsonConvert.DeserializeObject<Response>(responseString, settings);

                        var commitQuery = Work.GetCommitData(isGithubRepo, repoValue, item.UserOrganization, "");
                        var commitData = new StringContent(commitQuery, Encoding.UTF8, "application/json");
                        using var commitResponse = await httpClient.PostAsync("", commitData);
                        var commitResponseString = await commitResponse.Content.ReadAsStringAsync();
                        var commitResponseObj = JsonConvert.DeserializeObject<Response>(commitResponseString, settings);
                        
                        IList<Node> list = responseObj.Data.Repository.PullRequests.Nodes;
                        foreach(var listItem in list)
                        {
                            if (listItem.Title == null) { ViewBag.List = null; } else { ViewBag.List = list; }                                                          
                        }
                                               

                        List<Node> commitList = commitResponseObj.Data.Repository.DefaultBranchRef.Target.History.Nodes;
                        var freqs = Work.GetFrequenciesGithub(commitList);
                        ViewData["dictionary"] = freqs;
                    }                    
                }
            }

            async Task DevOpsPullRequest(bool isGithubRepo, string repoValue, string userValue)
            {
                using StreamReader r = new StreamReader("appsettings.json");                 
                string json = r.ReadToEnd();
                var config = JsonConvert.DeserializeObject<Settings>(json);

                foreach (var item in config.Info.Values)
                {
                    if (userValue == item.IndexNumber)
                    {
                        HttpClient httpClient = new HttpClient
                        {
                            BaseAddress = new Uri(Constants.DevOpsRESTAddress)
                        };
                        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes($":{item.Token}")));
                        httpClient.DefaultRequestHeaders.Accept.Clear();
                        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        httpClient.DefaultRequestHeaders.Add("User-Agent", "application");

                        HttpResponseMessage response = httpClient.GetAsync(Work.GetPullRequestData(isGithubRepo, repoValue, item.UserOrganization, item.Project)).Result;
                        var responseString = await response.Content.ReadAsStringAsync();
                        var deserializedRepo = JsonConvert.DeserializeObject<DevOpsResponse>(responseString);

                        IList<Value> list = deserializedRepo.Value;
                        foreach (var listItem in list)
                        {
                            if (listItem.Title == null) { ViewBag.List = null; } else { ViewBag.List = list; }
                        }

                        HttpResponseMessage commitResponse = httpClient.GetAsync(Work.GetCommitData(isGithubRepo, repoValue, item.UserOrganization, item.Project)).Result;
                        var commitResponseString = await commitResponse.Content.ReadAsStringAsync();
                        var deserializedCommit = JsonConvert.DeserializeObject<DevOpsResponse>(commitResponseString);

                        List<Value> commitList = deserializedCommit.Value;
                        var freqs = Work.GetFrequencies(commitList);
                        ViewData["dictionary"] = freqs;
                    }            
                }
            }                                        
        }
    }
}

