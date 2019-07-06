using System;
using Newtonsoft.Json;

namespace Reddit.Core.Data.Dtos
{
    public class FeedResponseDto
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subreddit_name_prefixed")]
        public string AuthorGroup { get; set; }

        [JsonProperty("thumbnail")]
        public string ContentUrl { get; set; }

        [JsonProperty("total_awards_received")]
        public int TotalAwards { get; set; }

        [JsonProperty("created")]
        public double CreatedAt { get; set; }
    }
}
