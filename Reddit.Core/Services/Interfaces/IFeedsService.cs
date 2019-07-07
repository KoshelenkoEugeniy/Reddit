using System;
using System.Threading.Tasks;
using Reddit.Core.Data.Dtos;

namespace Reddit.Core.Services.Interfaces
{
    public interface IFeedsService
    {
        Task<HomeResponseDto> GetHomeFeeds();
    }
}
