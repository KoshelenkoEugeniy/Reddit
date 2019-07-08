using System.Threading.Tasks;
using Reddit.Core.Data.Dtos;

namespace Reddit.Core.Services.Interfaces
{
    public interface IRedditApi
    {         Task<UserResponseDto> GetCurrentUser(AccessResponseDto token);

        Task<HomeResponseDto> GetUserHomeFeeds();
    }
}
