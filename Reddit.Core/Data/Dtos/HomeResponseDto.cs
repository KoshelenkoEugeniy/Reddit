namespace Reddit.Core.Data.Dtos
{
    public class HomeResponseDto
    {
        public string kind { get; set; }    //lower case for json parsing

        public FeedsGroupResponseDto data { get; set; }
    }
}
