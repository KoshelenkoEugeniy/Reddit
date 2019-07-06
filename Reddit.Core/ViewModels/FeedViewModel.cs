using System;
using MvvmCross.Core.ViewModels;
using Reddit.Core.Managers.Interfaces;

namespace Reddit.Core.ViewModels
{
    public class FeedViewModel : MvxViewModel
    {
        public MvxObservableCollection<string> TestCollection { get; set; }

        private IFeedsManager _feedsManager;
        private IAccountManager _accountManager;

        public FeedViewModel(IFeedsManager feedsManager, IAccountManager accountManager)
        {
            _feedsManager = feedsManager;
            _accountManager = accountManager;

            TestCollection = new MvxObservableCollection<string>
            { "q", "w", "e", "r", "t", "y"};
        }

        public override void ViewAppearing()
        {
            base.ViewAppearing();
        }
    }
}
