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

        public string Created { get; set; }

        public string Url { get; set; }

        public string TotalAwards { get; set; }
    }
}
