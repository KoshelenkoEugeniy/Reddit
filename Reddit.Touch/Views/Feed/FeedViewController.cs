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

        public FeedViewController() : base("FeedViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var source = new MvxSimpleTableViewSource(FeedsTableView, FeedTableViewCell.Key, FeedTableViewCell.Key)
            {
                DeselectAutomatically = true
            };
            FeedsTableView.Source = source;

            BindingSet = this.CreateBindingSet<FeedViewController, FeedViewModel>();
            BindingSet.Bind(source).To(vm => vm.TestCollection);
            //BindingSet.Bind(Source).For(s => s.SelectionChangedCommand).To(vm => vm.OpenPopCommand);
            BindingSet.Apply();
        }
    }
}

