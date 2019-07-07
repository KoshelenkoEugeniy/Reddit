using System;
namespace Reddit.Core.Data.Dtos
{
    public class FeedsGroupResponseDto
    {
        public int dist { get; set; }

        public WrappedFeedResponseDto[] children { get; set; }
    }
}
