using System;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Reddit.Core.Data.Models;
using Reddit.Core.Managers.Interfaces;
using Reddit.Core.Resources;

namespace Reddit.Core.ViewModels
{
    public class AuthViewModel : MvxViewModel, IMvxViewModel<string, UserModel>
    {
        public IMvxAsyncCommand LoginCommand { get; }

        public string TitleText => AppStrings.Auth_Title;

        public string SubtitleText => AppStrings.Auth_Subtitle;

        public string InfoText => AppStrings.Auth_LoginInfo;

        public string LoginText => AppStrings.Auth_Login;

        public string LoginHintText => AppStrings.Auth_LoginHint;

        public string LoginErrorText => AppStrings.Auth_LoginError;

        public string PasswordText => AppStrings.Auth_Password;

        public string PasswordHintText => AppStrings.Auth_PasswordHint;

        public string PasswordErrorText => AppStrings.Auth_PasswordError;

        private bool _isLoginError;
        public bool IsLoginError
        {
            get => _isLoginError;
            set => SetProperty(ref _isLoginError, value);
        }

        private string _login;
        public string Login
        {
            get => _login;
            set => SetProperty(ref _login, value);
        }

        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public TaskCompletionSource<object> CloseCompletionSource { get; set; }

        protected readonly IMvxNavigationService NavigationService;

        private IAccountManager _accountManager;

        public AuthViewModel(IAccountManager accountManager)
        {
            _accountManager = accountManager;
            NavigationService = Mvx.Resolve<IMvxNavigationService>();
            LoginCommand = new MvxAsyncCommand(DoLogin);
        }

        public void Prepare(string parameter)
        {
        }

        //public override ()
        //{
        //    if (CloseCompletionSource != null && !CloseCompletionSource.Task.IsCompleted && !CloseCompletionSource.Task.IsFaulted)
        //        CloseCompletionSource?.TrySetCanceled();
        //    base.ViewDestroy();         //} 

        private async Task DoLogin()
        {
            if(!string.IsNullOrEmpty(Login) && !string.IsNullOrEmpty(Password))
            {
                var user = await _accountManager.Login(Login, Password);
                if(user == null)
                {
                    IsLoginError = true;
                }
                else
                {
                    await NavigationService.Close(this, user);
                }
            }
            else
            {
                IsLoginError = true;
            }
        }
    }
}
