namespace Reddit.Core.Data.Dtos
{
    public class FeedResponseDto
    {
        public string title { get; set; }   //lower case for json parsing

        public string subreddit_name_prefixed { get; set; }

        public string author { get; set; }

        public string thumbnail { get; set; }

        public string post_hint { get; set; }

        public double created { get; set; }

        public string url { get; set; }

        public int total_awards_received { get; set; }
    }
}
