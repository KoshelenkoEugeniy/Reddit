using System;

using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
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

        protected FeedTableViewCell(IntPtr handle) : base(handle)
        {
            this.DelayBind(() =>             {                 var bindingSet = this.CreateBindingSet<FeedTableViewCell, string>();                 bindingSet.Bind(TitleLabel).To(vm => vm);                 bindingSet.Apply();             });
        }
    }
}
