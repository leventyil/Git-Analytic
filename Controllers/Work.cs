using GitAnalytic.Models;
using System.Collections.Generic;

namespace GitAnalytic.Controllers
{
    public static partial class Work
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isGithub"></param>
        /// <param name="isUser"></param>
        /// <param name="repoOwner"></param>
        /// <param name="DevOpsProject"></param>
        /// <returns></returns>
        public static string GetRepositories(bool isGithub, bool isUser, string repoOwner, string DevOpsProject)
        {
            if (isGithub)
            {
                if (isUser)
                    return $"{{\"query\":\"query($repoOwner: String!){{  user(login: $repoOwner) {{  repositories(orderBy: {{field: CREATED_AT, direction: DESC}}, affiliations: OWNER, last: 100) {{nodes {{ name }} }} }} }}\",\"variables\":{{\"repoOwner\":\"{repoOwner}\"}} }}";

                //organization
                return $"{{\"query\":\"query MyQuery($repoOwner : String!){{ organization(login: $repoOwner) {{  repositories(orderBy: {{field: CREATED_AT, direction: DESC}}, affiliations: OWNER, last: 100) {{nodes {{ name }} }} }} }}\",\"variables\":{{\"repoOwner\":\"{repoOwner}\"}} }}";
            }

            //Azure DevOps
            return $"{repoOwner}/{DevOpsProject}/_apis/git/repositories?api-version=6.0";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isGithub">Githuıb repo için 1 gönderilir.</param>
        /// <param name="repoName">jlasdjalkjd kljlads</param>
        /// <param name="repoOwner"></param>
        /// <param name="DevOpsProject"></param>
        /// <returns></returns>
        public static string GetPullRequestData(bool isGithub, string repoName, string repoOwner, string DevOpsProject)
        {
            if (isGithub)
                 return $"{{\"query\":\"query($repoName: String!, $repoOwner: String!){{  repository(name: $repoName, owner: $repoOwner) {{    pullRequests(orderBy: {{field: CREATED_AT, direction: DESC}},last: 10) {{nodes {{author {{login url}} closedAt createdAt state url body title number }} }} }} }}\",\"variables\":{{\"repoName\":\"{repoName}\",\"repoOwner\":\"{repoOwner}\"}} }}";
            
            //Azure DevOps
            return $"{repoOwner}/{DevOpsProject}/_apis/git/repositories/{repoName}/pullrequests?searchCriteria.status=all&api-version=6.0";      
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isGithub"></param>
        /// <param name="repoName"></param>
        /// <param name="repoOwner"></param>
        /// <param name="DevOpsProject"></param>
        /// <returns></returns>
        public static string GetCommitData(bool isGithub, string repoName, string repoOwner, string DevOpsProject)
        {

            if (isGithub)
                return $"{{\"query\":\"query($repoName: String!, $repoOwner: String!){{ repository(name: $repoName, owner: $repoOwner){{ defaultBranchRef{{ name  target{{... on Commit {{ history(first: 100) {{ totalCount nodes {{ author {{name }} message }} }} }} }} }} }} }}\",\"variables\":{{\"repoName\":\"{repoName}\",\"repoOwner\":\"{repoOwner}\"}} }}";

            //Azure DevOps
            return $"{repoOwner}/{DevOpsProject}/_apis/git/repositories/{repoName}/commits?searchCriteria.itemVersion.versionOptions=branch&api-version=6.0";
        }


        public static Dictionary<string, int> GetFrequencies(List<Value> values)
        {
            var result = new Dictionary<string, int>();
            foreach (var item in values)
            {
                if (result.TryGetValue(item.Author.Name, out int count))
                {
                    result[item.Author.Name] = count + 1;
                }
                else
                {
                    result.Add(item.Author.Name, 1);
                }
            }
            return result;
        }

        public static Dictionary<string, int> GetFrequenciesGithub(List<Node> values)
        {
            var result = new Dictionary<string, int>();
            foreach (var item in values)
            {
                if (result.TryGetValue(item.Author.Name, out int count))
                {
                    result[item.Author.Name] = count + 1;
                }
                else
                {
                    result.Add(item.Author.Name, 1);
                }
            }
            return result;
        }

    }    
}
