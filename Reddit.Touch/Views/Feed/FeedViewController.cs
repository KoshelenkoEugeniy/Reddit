using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using Reddit.Core.ViewModels;
using Reddit.Touch.Views.Feed.Data;
using UIKit;

namespace Reddit.Touch.Views.Feed
{
    public partial class FeedViewController : MvxViewController<FeedViewModel>
    {
        MvxFluentBindingDescriptionSet<FeedViewController, FeedViewModel> BindingSet;

        private FeedsTableSource source;

        public FeedViewController() : base("FeedViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            source = new FeedsTableSource(FeedsTableView);             FeedsTableView.Source = source;

            BindingSet = this.CreateBindingSet<FeedViewController, FeedViewModel>();
            BindingSet.Bind(this).For(v => v.Title).To(vm => vm.UserName);
            BindingSet.Bind(source).To(vm => vm.HomeFeeds);
            BindingSet.Apply();
        }
    }
}

