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

        public MvxImageViewLoader imageLoader;

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
            BindingSet.Bind(this).For(v => v.Title).To(vm => vm.Title);
            BindingSet.Bind(UserNameLabel).To(vm => vm.UserName);
            imageLoader = new MvxImageViewLoader(() => LogoImageViw, () => {                  if (LogoImageViw.Image != null)                 {                     LogoActivityIndicator.StopAnimating();                     LogoActivityIndicator.Hidden = true;                 }                 else                 {                     LogoActivityIndicator.Hidden = false;                     LogoActivityIndicator.StartAnimating();                 }             });
            BindingSet.Bind(imageLoader).To(vm => vm.LogoUrl);
            BindingSet.Bind(source).To(vm => vm.HomeFeeds);
            BindingSet.Apply();
        }
    }
}

