
using System.Net;

namespace GitAnalytic.Helpers
{
    public static class ConfigHelper   
    {                   

        public static bool IsUserRepo(long isUser)
        {
            return isUser == 1;
        }

        public static bool IsGithubRepo(long isGithub)
        {
            return isGithub == 1;
        }

        public static bool ResponseStatus(string status, long isGithubRepo)
        {
            if (isGithubRepo == 1) 
                return status != "Unauthorized";

            return status != "NonAuthoritativeInformation";
        }

        public static string UserInfoModifier(string userName, long isGithubRepo, long isUserRepo)
        {
            if (isGithubRepo == 1)
            {
                if (isUserRepo == 1)
                    return userName + " (Github User)";

                return userName + " (Github Organization)";
            }
            else
            {
                return userName + " (Azure DevOps Organization)";
            }
        }
    }
}
