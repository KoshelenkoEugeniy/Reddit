using System;
using System.Threading.Tasks;
using Reddit.Core.Data.Dtos;
using Refit;

namespace Reddit.Core.Services.Interfaces
{
    [Headers("Content-Type: application/json")]
    public interface IRedditApi
    {
        [Get("/api/v1/me")]         [Headers("Authorization: Bearer")]         Task<DefaultResponse<UserResponseDto>> GetCurrentUser();

        [Get("/api/v1/access_token?grant_type=password&username={userName}&password={password}")]
        [Headers("Authorization: Bearer")]
        Task<DefaultResponse<AccessResponseDto>> GetUserToken(string userName, string password);
    }
}
