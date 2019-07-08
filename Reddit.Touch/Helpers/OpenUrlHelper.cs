using Foundation;
using Reddit.Core.Helpers.Interfaces;
using UIKit;

namespace Reddit.Touch.Helpers
{
    public class OpenUrlHelper : IOpenUrlHelper     {
        public void OpenUrl(string url)         {
            if (string.IsNullOrEmpty(url))
                return;

            var nsUrl = NSUrl.FromString(url);              if (UIApplication.SharedApplication.CanOpenUrl(nsUrl))
                UIApplication.SharedApplication.OpenUrl(nsUrl);         }

        public void Call(string url)
        {
            if (string.IsNullOrEmpty(url))
                return;

            var nsUrl = NSUrl.FromString(url);              if (UIApplication.SharedApplication.CanOpenUrl(nsUrl))
                UIApplication.SharedApplication.OpenUrl(nsUrl);
        }
    }
}
