using System;
using System.Threading.Tasks;
using Reddit.Core.Data.Dtos;
using Reddit.Core.Services.Interfaces;

namespace Reddit.Core.Services
{
    public class FeedsService: BaseService, IFeedsService
    {
        public async Task<HomeResponseDto> GetHomeFeeds()
        {
            var result = await ApiService.Client.GetUserHomeFeeds();
            return result;
        }
    }
}
