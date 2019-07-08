namespace Reddit.Core.Data.Dtos
{
    public class WrappedFeedResponseDto
    {
        public string kind { get; set; }    //lower case for json parsing
        public FeedResponseDto data { get; set; }
    }
}
