using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Reddit.Core.Data.Models;
using Reddit.Core.Helpers.Interfaces;
using Reddit.Core.Managers.Interfaces;

namespace Reddit.Core.ViewModels
{
    public class FeedViewModel : MvxViewModel
    {
        public MvxObservableCollection<FeedModel> HomeFeeds { get; set; }

        public IMvxAsyncCommand<FeedModel> OpenFeedCommand { get; set; }

        private string _userName;
        public string UserName
        {
            get => _userName;
            set 
            {
                SetProperty(ref _userName, value); 
            }
        }

        protected readonly IMvxNavigationService NavigationService;

        private IFeedsManager _feedsManager;

        private IAccountManager _accountManager;

        private IOpenUrlHelper _urlHelper;

        public FeedViewModel(IFeedsManager feedsManager, IAccountManager accountManager, IOpenUrlHelper urlHelper)
        {
            NavigationService = Mvx.Resolve<IMvxNavigationService>();

            _feedsManager = feedsManager;
            _accountManager = accountManager;
            _urlHelper = urlHelper;

            HomeFeeds = new MvxObservableCollection<FeedModel>();
            OpenFeedCommand = new MvxAsyncCommand<FeedModel>(OpenFeed);
        }

        public async override void ViewAppearing()
        {
            UserName = _accountManager.CurrentUser.UserName;

            if (string.IsNullOrEmpty(_accountManager.CurrentUser.UserName))
            {
                await NavigationService.Navigate<AuthViewModel>();
            }
            else
            {
                HomeFeeds.AddRange(await _feedsManager.GetHomeFeeds());
            }
        }

        private async Task OpenFeed(FeedModel feed)
        {
            _urlHelper.OpenUrl(feed.Url);
        }
    }
}
