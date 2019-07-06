using System;
using Newtonsoft.Json;

namespace Reddit.Core.Data.Dtos
{
    public class UserResponseDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon_img")]         public string LogoUrl { get; set; }
    }
}
