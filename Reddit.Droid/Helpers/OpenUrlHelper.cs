using Android.Content; using MvvmCross.Platform.Droid.Platform; using Reddit.Core.Helpers.Interfaces;

namespace Reddit.Droid.Helpers {     public class OpenUrlHelper : MvxAndroidTask, IOpenUrlHelper     {
        public void OpenUrl(string url)         {
            if (string.IsNullOrEmpty(url))
                return;

            var intent = new Intent(Intent.ActionView, Android.Net.Uri.Parse(url));             StartActivity(intent);
        }
    } } 

