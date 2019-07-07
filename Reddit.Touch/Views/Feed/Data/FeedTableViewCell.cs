using System;

using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using Reddit.Core.Data.Models;
using Reddit.Core.Resources;
using UIKit;

namespace Reddit.Touch.Views.Feed.Data
{
    public partial class FeedTableViewCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("FeedTableViewCell");
        public static readonly UINib Nib;

        static FeedTableViewCell()
        {
            Nib = UINib.FromName("FeedTableViewCell", NSBundle.MainBundle);
        }

        private MvxImageViewLoader _imageLoader;

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

            FirstSeparatorView.Layer.CornerRadius = (nfloat)2.5;
            SecondSeparatorView.Layer.CornerRadius = (nfloat)2.5;
        }

        protected FeedTableViewCell(IntPtr handle) : base(handle)
        {
            this.DelayBind(() =>             {                 var bindingSet = this.CreateBindingSet<FeedTableViewCell, FeedModel>();
                bindingSet.Bind(GroupLabel).To(vm => vm.Group);
                bindingSet.Bind(AuthorLabel).To(vm => vm.AuthorName);
                bindingSet.Bind(TimeLabel).To(vm => vm.Created);
                bindingSet.Bind(AwardsQuantityLabel).To(vm => vm.TotalAwards);                 bindingSet.Bind(TitleLabel).To(vm => vm.Title);
                _imageLoader = new MvxImageViewLoader(() => PostImageView, () =>
                {
                    if (PostImageView.Image != null)
                    {
                        ImageLoadingIndicator.StopAnimating();
                        ImageLoadingIndicator.Hidden = true;
                    }
                    else
                    {
                        ImageLoadingIndicator.Hidden = false;
                        ImageLoadingIndicator.StartAnimating();
                    }
                });
                bindingSet.Bind(_imageLoader).To(vm => vm.Thumbnail);                 bindingSet.Apply();             });
        }
    }
}
