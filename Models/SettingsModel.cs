using System.Collections.Generic;
using Newtonsoft.Json;

namespace GitAnalytic.Models
{
    public partial class Settings
    {
        [JsonProperty("info")]
        public Info Info { get; set; }
    }

    public partial class Info
    {
        [JsonProperty("values")]
        public List<Values> Values { get; set; }
    }

    public partial class Values
    {
        [JsonProperty("indexNumber")]
        public string IndexNumber { get; set; }

        [JsonProperty("isGithubRepo")]
        public long IsGithubRepo { get; set; }

        [JsonProperty("isUserRepo")]
        public long IsUserRepo { get; set; }

        [JsonProperty("user/organization")]
        public string UserOrganization { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }
    }
}
