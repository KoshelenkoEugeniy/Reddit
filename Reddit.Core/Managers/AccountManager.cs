using System;
using System.Threading.Tasks;
using Reddit.Core.Data.Mappers;
using Reddit.Core.Data.Models;
using Reddit.Core.Managers.Interfaces;
using Reddit.Core.Services.Interfaces;

namespace Reddit.Core.Managers
{
    public class AccountManager: IAccountManager
    {
        public UserModel CurrentUser { get; set; }

        private IAccountService _accountService;

        public AccountManager(IAccountService accountService)
        {
            _accountService = accountService;
            CurrentUser = new UserModel();
        }

        public async Task<UserModel> Login(string userName, string password)
        {
            var token = await _accountService.GetAccessToken(userName, password);

            if(token != null)
            {
                var userInfo = await _accountService.GetUser(token);
                CurrentUser = userInfo.DataToModel();
                return CurrentUser;
            }
            else
            {
                return null;
            }
        }
    }
}
