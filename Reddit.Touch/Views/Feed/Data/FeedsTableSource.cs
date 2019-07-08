using System;
using Foundation;
using MvvmCross.Binding.iOS.Views;
using Reddit.Core.Data.Models;
using UIKit;

namespace Reddit.Touch.Views.Feed.Data
{
    public class FeedsTableSource : MvxTableViewSource
    {
        public FeedsTableSource(UITableView tableView) : base(tableView)
        {
            tableView.RegisterNibForCellReuse(FeedTableViewCell.Nib, FeedTableViewCell.Key);             tableView.RegisterNibForCellReuse(FeedTextTableViewCell.Nib, FeedTextTableViewCell.Key);
        }

        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
        {
            NSString _cellIdentifier;              FeedModel currentItem = (FeedModel)item;

            _cellIdentifier = currentItem.PostType == "image"?
                                    FeedTableViewCell.Key :
                                    FeedTextTableViewCell.Key;


            var cell = tableView.DequeueReusableCell(_cellIdentifier, indexPath);                             return cell;
        }
    }
}
