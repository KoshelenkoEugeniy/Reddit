using System;
namespace Reddit.Core.Data.Models
{
    public class FeedModel
    {
        public string Group { get; set; }

        public string Title { get; set; }

        public string AuthorName { get; set; }

        public string Thumbnail { get; set; }

        public string PostType { get; set; }

        public DateTime Created { get; set; }

        public string Url { get; set; }

        public int TotalAwards { get; set; }
    }
}
