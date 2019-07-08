namespace Reddit.Core.Data.Dtos
{
    public class FeedsGroupResponseDto
    {
        public int dist { get; set; }   //lower case for json parsing

        public WrappedFeedResponseDto[] children { get; set; }
    }
}
