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
    public class FeedViewModel : MvxViewModel
    {
        public MvxObservableCollection<FeedModel> HomeFeeds { get; set; }

        public string Title => AppStrings.Feed_HomeTitle;

        private string _userName;
        public string UserName
        {
            get => _userName;
            set 
            {
                SetProperty(ref _userName, value); 
            }
        }

        private string _logoUrl;
        public string LogoUrl
        {
            get => _logoUrl;
            set
            {
                SetProperty(ref _logoUrl, value);
            }
        }

        protected readonly IMvxNavigationService NavigationService;

        private IFeedsManager _feedsManager;

        private IAccountManager _accountManager;

        private UserModel currentUser = new UserModel();

        public FeedViewModel(IFeedsManager feedsManager, IAccountManager accountManager)
        {
            NavigationService = Mvx.Resolve<IMvxNavigationService>();

            _feedsManager = feedsManager;
            _accountManager = accountManager;

            HomeFeeds = new MvxObservableCollection<FeedModel>();
        }

        public async override void ViewAppearing()
        {
            UserName = _accountManager.CurrentUser.UserName;
            LogoUrl = _accountManager.CurrentUser.LogoUrl;

            if (string.IsNullOrEmpty(_accountManager.CurrentUser.UserName))
            {
                await NavigationService.Navigate<AuthViewModel>();
            }
            else
            {
                HomeFeeds.AddRange(await _feedsManager.GetHomeFeeds());
            }
        }
    }
}
