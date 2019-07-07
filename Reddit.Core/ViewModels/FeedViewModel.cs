using System;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Reddit.Core.Data.Models;
using Reddit.Core.Managers.Interfaces;

namespace Reddit.Core.ViewModels
{
    public class FeedViewModel : MvxViewModel
    {
        //public MvxObservableCollection<string> TestCollection { get; set; }

        protected readonly IMvxNavigationService NavigationService;

        //private IFeedsManager _feedsManager;

        //private IAccountManager _accountManager;

        private UserModel currentUser = new UserModel();

        public FeedViewModel(IFeedsManager feedsManager, IAccountManager accountManager)
        {
            NavigationService = Mvx.Resolve<IMvxNavigationService>();

            //_feedsManager = feedsManager;
            //_accountManager = accountManager;

            //TestCollection = new MvxObservableCollection<string>
            //{ "q", "w", "e", "r", "t", "y"};
        }

        public async override void ViewAppearing()
        {
            base.ViewAppearing();
            //_accountManager.Login("EugeneKoshelenko", "qwerty123456");
            
            var user = await NavigationService.Navigate<AuthViewModel, string, UserModel>(string.Empty);

            var x = 1;
        }
    }
}
