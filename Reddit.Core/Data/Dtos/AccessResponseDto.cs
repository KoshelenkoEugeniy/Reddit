namespace Reddit.Core.Data.Dtos
{
    public class AccessResponseDto
    {
        public string access_token { get; set; }    //lower case for json parsing

        public int expires_in { get; set; }

        public string scope { get; set; }

        public string token_type { get; set; }
    }
}
