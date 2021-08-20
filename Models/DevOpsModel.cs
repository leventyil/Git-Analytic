using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GitAnalytic.Models
{
    public partial class DevOpsResponse
    {
        [JsonProperty("value")]
        public List<Value> Value { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }
    }

    public partial class Value
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("project")]
        public Project Project { get; set; }

        [JsonProperty("defaultBranch")]
        public string DefaultBranch { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("remoteUrl")]
        public Uri RemoteUrl { get; set; }

        [JsonProperty("sshUrl")]
        public string SshUrl { get; set; }

        [JsonProperty("webUrl")]
        public Uri WebUrl { get; set; }

        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("repository")]
        public Repository Repository { get; set; }

        [JsonProperty("pullRequestId")]
        public long PullRequestId { get; set; }

        [JsonProperty("codeReviewId")]
        public long CodeReviewId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("createdBy")]
        public CreatedBy CreatedBy { get; set; }

        [JsonProperty("creationDate")]
        public DateTimeOffset CreationDate { get; set; }

        [JsonProperty("closedDate")]
        public DateTimeOffset ClosedDate { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sourceRefName")]
        public string SourceRefName { get; set; }

        [JsonProperty("targetRefName")]
        public string TargetRefName { get; set; }

        [JsonProperty("isDraft")]
        public bool IsDraft { get; set; }

        [JsonProperty("mergeId")]
        public Guid MergeId { get; set; }

        [JsonProperty("lastMergeSourceCommit")]
        public LastMergeCommit LastMergeSourceCommit { get; set; }

        [JsonProperty("lastMergeTargetCommit")]
        public LastMergeCommit LastMergeTargetCommit { get; set; }

        [JsonProperty("reviewers")]
        public List<object> Reviewers { get; set; }

        [JsonProperty("supportsIterations")]
        public bool SupportsIterations { get; set; }

        [JsonProperty("commitId")]
        public string CommitId { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("committer")]
        public Author Committer { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("changeCounts")]
        public ChangeCounts ChangeCounts { get; set; }

        [JsonProperty("commentTruncated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CommentTruncated { get; set; }
    }

    public partial class Author
    {
        [JsonProperty("email")]
        public object Email { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }
    }

    public partial class ChangeCounts
    {
        [JsonProperty("Add")]
        public long Add { get; set; }

        [JsonProperty("Edit")]
        public long Edit { get; set; }

        [JsonProperty("Delete")]
        public long Delete { get; set; }
    }

    public partial class CreatedBy
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("uniqueName")]
        public object UniqueName { get; set; }

        [JsonProperty("imageUrl")]
        public object ImageUrl { get; set; }

        [JsonProperty("descriptor")]
        public string Descriptor { get; set; }
    }

    public partial class Links
    {
        [JsonProperty("avatar")]
        public Avatar Avatar { get; set; }
    }

    public partial class Avatar
    {
        [JsonProperty("href")]
        public Uri Href { get; set; }
    }

    public partial class LastMergeCommit
    {
        [JsonProperty("commitId")]
        public string CommitId { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public partial class Repository
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("project")]
        public Project Project { get; set; }
    }

    public partial class Project
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("revision")]
        public long Revision { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("lastUpdateTime")]
        public string LastUpdateTime { get; set; }
    }

    public partial class DevOpsResponse
    {
        public static DevOpsResponse FromJson(string json) => JsonConvert.DeserializeObject<DevOpsResponse>(json, GitAnalytic.Models.Converter2.Settings);
    }

    public static class Serialize2
    {
        public static string ToJson(this DevOpsResponse self) => JsonConvert.SerializeObject(self, GitAnalytic.Models.Converter2.Settings);
    }

    internal static class Converter2
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
