using System;
namespace Reddit.Core.Data.Models
{
    public class AccessModel
    {
        public string access_token { get; set; }

        public int expires_in { get; set; }

        public string scope { get; set; }

        public string token_type { get; set; }
    }
}
