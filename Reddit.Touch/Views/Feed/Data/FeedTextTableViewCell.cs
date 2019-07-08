using System;

using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using Reddit.Core.Data.Models;
using UIKit;

namespace Reddit.Touch.Views.Feed.Data
{
    public partial class FeedTextTableViewCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("FeedTextTableViewCell");
        public static readonly UINib Nib;

        static FeedTextTableViewCell()
        {
            Nib = UINib.FromName("FeedTextTableViewCell", NSBundle.MainBundle);
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

            FirstSeparatorView.Layer.CornerRadius = (nfloat)2.5;
            SecondSeparatorView.Layer.CornerRadius = (nfloat)2.5;
        }

        protected FeedTextTableViewCell(IntPtr handle) : base(handle)
        {
            this.DelayBind(() =>
            {
                var bindingSet = this.CreateBindingSet<FeedTextTableViewCell, FeedModel>();
                bindingSet.Bind(GroupLabel).To(vm => vm.Group);
                bindingSet.Bind(AuthorLabel).To(vm => vm.AuthorName);
                bindingSet.Bind(TimeLabel).To(vm => vm.Created);
                bindingSet.Bind(AwardsQuantityLabel).To(vm => vm.TotalAwards);
                bindingSet.Bind(TitleLabel).To(vm => vm.Title);
                bindingSet.Bind(LinkLabel).To(vm => vm.Url);
                bindingSet.Apply();
            });
        }
    }
}
