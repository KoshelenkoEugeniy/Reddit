using System;
using Reddit.Core.Data.Models;
using Reddit.Core.Managers.Interfaces;
using Reddit.Core.Services.Interfaces;

namespace Reddit.Core.Managers
{
    public class AccountManager: IAccountManager
    {
        private IAccountService _accountService;

        public AccountManager(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public AccessModel GetAccessToken(string userName, string password)
        {
            return null;
        }
    }
}
