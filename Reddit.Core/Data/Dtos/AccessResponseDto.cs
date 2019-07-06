using System;
using Newtonsoft.Json;

namespace Reddit.Core.Data.Dtos
{
    public class AccessResponseDto
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("expires_in")]         public int ExpiresIn { get; set; }

        [JsonProperty("scope")]         public string Scope { get; set; }

        [JsonProperty("token_type")]         public string TokenType { get; set; }
    }
}
