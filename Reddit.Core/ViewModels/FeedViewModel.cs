using System;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Reddit.Core.Data.Models;
using Reddit.Core.Managers.Interfaces;

namespace Reddit.Core.ViewModels
{
    public class FeedViewModel : MvxViewModel
    {
        public MvxObservableCollection<FeedModel> HomeFeeds { get; set; }

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
