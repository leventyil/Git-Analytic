using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using GitAnalytic.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using GitAnalytic.Helpers;
using System.IO;

namespace GitAnalytic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            using (StreamReader r = new StreamReader("appsettings.json"))
            {
                string json = r.ReadToEnd();
                var config = JsonConvert.DeserializeObject<Settings>(json);
                List<SelectListItem> users = new List<SelectListItem>();

                int i = 1;
                foreach (var item in config.Info.Values)
                {                   
                    users.Add(new SelectListItem
                    {
                        Text = ConfigHelper.UserInfoModifier(item.UserOrganization, item.IsGithubRepo, item.IsUserRepo),
                        Value = $"{i}"
                    });
                    i++;
                }
                ViewBag.userNames = users;            
            }
            return View();
        }

        [HttpPost]
        public async Task<PartialViewResult> Post()
        {
            using StreamReader r = new StreamReader("appsettings.json");
            string json = r.ReadToEnd();
            var config = JsonConvert.DeserializeObject<Settings>(json);

            string userValue = Request.Form["User"].ToString();

            foreach (var item in config.Info.Values)
            {
                if (userValue == item.IndexNumber)
                {
                    bool isGithubRepo = ConfigHelper.IsGithubRepo(item.IsGithubRepo);
                    bool isUserRepo = ConfigHelper.IsUserRepo(item.IsUserRepo);

                    if (isGithubRepo){ await GithubRepoRequest(isGithubRepo, isUserRepo); } 
                    else{ await DevOpsRepoRequest(isGithubRepo, isUserRepo); }
                                                           
                }                    
            }
            return PartialView("_Repo");


            async Task GithubRepoRequest(bool isGithubRepo, bool isUserRepo)
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

                        var repositories = Work.GetRepositories(isGithubRepo, isUserRepo, item.UserOrganization, "");
                        var repoData = new StringContent(repositories, Encoding.UTF8, "application/json");
                        using var response = await httpClient.PostAsync("", repoData);
                        var responseString = await response.Content.ReadAsStringAsync();
                        var deserializedRepo = JsonConvert.DeserializeObject<Response>(responseString);
                       
                        bool status = ConfigHelper.ResponseStatus(response.StatusCode.ToString(), item.IsGithubRepo);
                        ViewBag.ResponseStatus = status;

                        List <SelectListItem> repos = new List<SelectListItem>();
                        if (isUserRepo && status)
                        {
                            foreach (var items in deserializedRepo.Data.User.Repositories.Nodes)
                            {
                                repos.Add(new SelectListItem
                                {
                                    Text = items.Name,
                                    Value = items.Name
                                });
                            }
                            ViewBag.repoNames = repos;
                        }
                        else if(status)
                        {
                            foreach (var items in deserializedRepo.Data.Organization.Repositories.Nodes)
                            {
                                repos.Add(new SelectListItem
                                {
                                    Text = items.Name,
                                    Value = items.Name
                                });
                            }
                            ViewBag.repoNames = repos;
                        }                       
                    }
                }
            }

            async Task DevOpsRepoRequest(bool isGithubRepo, bool isUserRepo)
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

                        HttpResponseMessage response = httpClient.GetAsync(Work.GetRepositories(isGithubRepo, isUserRepo, item.UserOrganization, item.Project)).Result;
                        var responseString = await response.Content.ReadAsStringAsync();

                        bool status = ConfigHelper.ResponseStatus(response.StatusCode.ToString(), item.IsGithubRepo);
                        ViewBag.ResponseStatus = status;

                        if (status)
                        {
                            var deserializedRepo = JsonConvert.DeserializeObject<DevOpsResponse>(responseString);

                            List<SelectListItem> repos = new List<SelectListItem>();
                            foreach (var items in deserializedRepo.Value)
                            {
                                repos.Add(new SelectListItem
                                {
                                    Text = items.Name,
                                    Value = items.Id.ToString()
                                });
                            }
                            ViewBag.repoNames = repos;
                        }                    
                    }
                }
            }
        }       
    }
}