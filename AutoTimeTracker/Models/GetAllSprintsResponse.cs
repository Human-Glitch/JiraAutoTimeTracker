using System.Text.Json.Serialization;

namespace AutoTimeTracker.Models
{
    public class GetAllSprintsResponse
    {
        [JsonPropertyName("maxResults")]
        public int MaxResults { get; set; }

        [JsonPropertyName("startAt")]
        public int StartAt { get; set; }

        [JsonPropertyName("isLast")]
        public bool IsLast { get; set; }

        [JsonPropertyName("values")]
        public Value[] Values { get; set; }

        public class Value
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("self")]
            public string Self { get; set; }

            [JsonPropertyName("state")]
            public string State { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("startDate")]
            public DateTime StartDate { get; set; }

            [JsonPropertyName("endDate")]
            public DateTime EndDate { get; set; }

            [JsonPropertyName("createdDate")]
            public DateTime createdDate { get; set; }

            [JsonPropertyName("originBoardId")]
            public int OriginBoardId { get; set; }

            [JsonPropertyName("goal")]
            public string Goal { get; set; }
        }

    }
}
