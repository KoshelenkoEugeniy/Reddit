// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Reddit.Touch.Views.Feed
{
	[Register ("FeedViewController")]
	partial class FeedViewController
	{
		[Outlet]
		UIKit.UITableView FeedsTableView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (FeedsTableView != null) {
				FeedsTableView.Dispose ();
				FeedsTableView = null;
			}
		}
	}
}
