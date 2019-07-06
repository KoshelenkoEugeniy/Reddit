using System;
using Reddit.Core.Data.Dtos;

namespace Reddit.Core.Services.Interfaces
{
    public interface IAccountService
    {
        AccessResponseDto GetAccessToken(string userName, string password);
    }
}
