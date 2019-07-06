using System;
namespace Reddit.Core.Data.Models
{
    public class AccessModel
    {
        public string AccessToken { get; set; }

        public int ExpiresIn { get; set; }

        public string Scope { get; set; }

        public string TokenType { get; set; }
    }
}
