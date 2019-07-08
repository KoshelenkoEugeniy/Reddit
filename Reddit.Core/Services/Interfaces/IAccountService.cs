using System.Threading.Tasks;
using Reddit.Core.Data.Dtos;

namespace Reddit.Core.Services.Interfaces
{
    public interface IAccountService
    {
        Task<AccessResponseDto> GetAccessToken(string userName, string password);

        Task<UserResponseDto> GetUser(AccessResponseDto token);
    }
}
