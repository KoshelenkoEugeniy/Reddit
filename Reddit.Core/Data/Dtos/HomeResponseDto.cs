using System;
namespace Reddit.Core.Data.Dtos
{
    public class HomeResponseDto
    {
        public string kind { get; set; }

        public FeedsGroupResponseDto data { get; set; }
    }
}
