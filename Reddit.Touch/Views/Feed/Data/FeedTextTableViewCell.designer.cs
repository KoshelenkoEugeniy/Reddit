// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Reddit.Touch.Views.Feed.Data
{
	[Register ("FeedTextTableViewCell")]
	partial class FeedTextTableViewCell
	{
		[Outlet]
		UIKit.UILabel AuthorLabel { get; set; }

		[Outlet]
		UIKit.UILabel AwardsQuantityLabel { get; set; }

		[Outlet]
		UIKit.UIView FirstSeparatorView { get; set; }

		[Outlet]
		UIKit.UILabel GroupLabel { get; set; }

		[Outlet]
		UIKit.UILabel LinkLabel { get; set; }

		[Outlet]
		UIKit.UIView SecondSeparatorView { get; set; }

		[Outlet]
		UIKit.UILabel TimeLabel { get; set; }

		[Outlet]
		UIKit.UILabel TitleLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (AuthorLabel != null) {
				AuthorLabel.Dispose ();
				AuthorLabel = null;
			}

			if (AwardsQuantityLabel != null) {
				AwardsQuantityLabel.Dispose ();
				AwardsQuantityLabel = null;
			}

			if (FirstSeparatorView != null) {
				FirstSeparatorView.Dispose ();
				FirstSeparatorView = null;
			}

			if (GroupLabel != null) {
				GroupLabel.Dispose ();
				GroupLabel = null;
			}

			if (LinkLabel != null) {
				LinkLabel.Dispose ();
				LinkLabel = null;
			}

			if (SecondSeparatorView != null) {
				SecondSeparatorView.Dispose ();
				SecondSeparatorView = null;
			}

			if (TimeLabel != null) {
				TimeLabel.Dispose ();
				TimeLabel = null;
			}

			if (TitleLabel != null) {
				TitleLabel.Dispose ();
				TitleLabel = null;
			}
		}
	}
}
