using System;
using System.Threading.Tasks;
using Reddit.Core.Data.Dtos;
using Reddit.Core.Data.Models;

namespace Reddit.Core.Services.Interfaces
{
    public interface IAccountService
    {
        Task<AccessResponseDto> GetAccessToken(string userName, string password);

        Task<UserResponseDto> GetUser(AccessResponseDto token);
    }
}
