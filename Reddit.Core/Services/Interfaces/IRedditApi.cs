using System;
using System.Threading.Tasks;
using Reddit.Core.Data.Dtos;
using Refit;

namespace Reddit.Core.Services.Interfaces
{
    public interface IRedditApi
    {         Task<UserResponseDto> GetCurrentUser(AccessResponseDto token);

    }
}
