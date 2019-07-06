using System;
using Newtonsoft.Json;

namespace Reddit.Core.Data.Dtos
{
    public class DefaultResponse<T>
    {
        [JsonProperty("data")]
        public T data;
    }
}
