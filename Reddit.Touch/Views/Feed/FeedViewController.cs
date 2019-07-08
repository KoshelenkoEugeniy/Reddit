using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using Reddit.Core.ViewModels;
using Reddit.Touch.Views.Feed.Data;

namespace Reddit.Touch.Views.Feed
{
    public partial class FeedViewController : MvxViewController<FeedViewModel>
    {
        MvxFluentBindingDescriptionSet<FeedViewController, FeedViewModel> BindingSet;

        public FeedViewController() : base("FeedViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var source = new MvxSimpleTableViewSource(FeedsTableView, FeedTextTableViewCell.Key, FeedTextTableViewCell.Key)
            {
                DeselectAutomatically = true
            };
            FeedsTableView.Source = source;

            BindingSet = this.CreateBindingSet<FeedViewController, FeedViewModel>();
            BindingSet.Bind(this).For(v => v.Title).To(vm => vm.UserName);
            BindingSet.Bind(source).For(s => s.SelectionChangedCommand).To(vm => vm.OpenFeedCommand);
            BindingSet.Bind(source).To(vm => vm.HomeFeeds);
            BindingSet.Apply();
        }
    }
}

