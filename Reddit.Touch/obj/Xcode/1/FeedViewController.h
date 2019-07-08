// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <MvvmCross/MvvmCross.h>
#import <UIKit/UIKit.h>


@interface FeedViewController : UIViewController {
	UITableView *_FeedsTableView;
	UIActivityIndicatorView *_LogoActivityIndicator;
	UIImageView *_LogoImageView;
	UILabel *_UserNameLabel;
}

@property (nonatomic, retain) IBOutlet UITableView *FeedsTableView;

@property (nonatomic, retain) IBOutlet UIActivityIndicatorView *LogoActivityIndicator;

@property (nonatomic, retain) IBOutlet UIImageView *LogoImageView;

@property (nonatomic, retain) IBOutlet UILabel *UserNameLabel;

@end
