using Foundation;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform;
using UIKit;

namespace Reddit.Touch
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate
    {
        // class-level declarations

        UIWindow _window;

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            _window = new UIWindow(UIScreen.MainScreen.Bounds);

            var presenter = new MvxIosViewPresenter(this, _window);
            var setup = new Setup(this, presenter);
            setup.Initialize();

            var startUp = Mvx.Resolve<IMvxAppStart>();
            startUp.Start();

            _window.MakeKeyAndVisible();

            return true;
        }
    }
}

