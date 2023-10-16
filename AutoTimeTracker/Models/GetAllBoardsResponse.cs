using System.Text.Json.Serialization;

namespace AutoTimeTracker.Models
{
    public class GetAllBoardsResponse
    {
        [JsonPropertyName("maxResults")]
        public int MaxResults { get; set; }

        [JsonPropertyName("startAt")]
        public int StartAt { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("isLast")]
        public bool IsLast { get; set; }

        [JsonPropertyName("values")]
        public List<Value> Values { get; set; }

        public class Value
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("self")]
            public string Self { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("type")]
            public string Type { get; set; }

            [JsonPropertyName("location")]
            public Location Location { get; set; }
        }

        public class Location
        {
            [JsonPropertyName("projectId")]
            public int ProjectId { get; set; }

            [JsonPropertyName("displayName")]
            public string DisplayName { get; set; }

            [JsonPropertyName("projectName")]
            public string ProjectName { get; set; }

            [JsonPropertyName("projectKey")]
            public string ProjectKey { get; set; }

            [JsonPropertyName("projectTypeKey")]
            public string ProjectTypeKey { get; set; }

            [JsonPropertyName("avatarURI")]
            public string AvatarUri { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }
        }

    }
}
