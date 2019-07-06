using System;
using Reddit.Core.Data.Dtos;
using Reddit.Core.Services.Interfaces;

namespace Reddit.Core.Services
{
    public class AccountService: BaseService, IAccountService
    {
        public AccountService()
        {
        }

        public AccessResponseDto GetAccessToken(string userName, string password)
        {
            return null;
        }
    }
}
