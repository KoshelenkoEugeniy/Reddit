using System;
namespace Reddit.Core
{
    public static class GlobalConstants
    {
        public static class Api
        {
            public const string OauthBaseAddress = "https://oauth.reddit.com";

            public const string AuthAddress = "https://www.reddit.com";

            public static TimeSpan TimeoutSpan => TimeSpan.FromSeconds(10);

            public static TimeSpan SleepRetrySpan => TimeSpan.FromSeconds(2);

            public const int RetryCount = 2;
        }

        public static class RedditApp
        {
            public const string AppId = "P3pPLAYfUy7Prw";

            public const string AppSecret = "9dTkmtYuqlQIzDDw81IMuwLCUZA";
        }
    }
}
