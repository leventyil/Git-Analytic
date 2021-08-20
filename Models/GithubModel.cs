using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GitAnalytic.Models
{
    public partial class Response
    {

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("repository")]
        public Repository Repository { get; set; }

        [JsonProperty("organization")]
        public Organization Organization { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public partial class User
    {
        [JsonProperty("repositories")]
        public Repositories Repositories { get; set; }
    }

    public partial class Organization
    {
        [JsonProperty("repositories")]
        public Repositories Repositories { get; set; }

        [JsonProperty("repository")]
        public Repository Repository { get; set; }
    }

    public partial class Repositories
    {
        [JsonProperty("nodes")]
        public List<Node> Nodes { get; set; }
    }

    public partial class Repository
    {
        [JsonProperty("pullRequests")]
        public PullRequests PullRequests { get; set; }

        [JsonProperty("defaultBranchRef")]
        public DefaultBranchRef DefaultBranchRef { get; set; }
    }

    public partial class DefaultBranchRef
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("target")]
        public Target Target { get; set; }
    }

    public partial class Target
    {
        [JsonProperty("history")]
        public History History { get; set; }
    }

    public partial class History
    {
        [JsonProperty("totalCount")]
        public long TotalCount { get; set; }

        [JsonProperty("nodes")]
        public List<Node> Nodes { get; set; }
    }

    public partial class PullRequests
    {
        [JsonProperty("nodes")]
        public List<Node> Nodes { get; set; }
    }

    public partial class Node
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("closedAt")]
        public DateTimeOffset ClosedAt { get; set; }

        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Author
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
    
    public partial class Response
    {
        public static Response FromJson(string json) => JsonConvert.DeserializeObject<Response>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Response self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
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
