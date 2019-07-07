using System;
namespace Reddit.Core.Data.Dtos
{
    public class WrappedFeedResponseDto
    {
        public string kind { get; set; }
        public FeedResponseDto data { get; set; }
    }
}
