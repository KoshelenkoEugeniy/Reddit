using System;
using Reddit.Core.Data.Dtos;
using Reddit.Core.Data.Models;
using Reddit.Core.Resources;

namespace Reddit.Core.Data.Mappers
{
    public static class FeedMapper
    {
        public static FeedModel DataToModel(this FeedResponseDto data, FeedModel model = null)
        {
            if (data == null)
                return null;

            if (model == null)
                model = new FeedModel();

            model.AuthorName = string.Format(AppStrings.Feed_PostedByText, data.author);
            model.Group = data.subreddit_name_prefixed;
            model.PostType = data.post_hint;
            model.Created = string.Format( AppStrings.Feed_CreatedAgo, ConvertFromUnixTimestamp((int)data.created));
            model.Thumbnail = data.thumbnail;
            model.Title = data.title;
            model.TotalAwards = string.Format(AppStrings.Feed_AwardsText, data.total_awards_received);
            model.Url = data.url;

            return model;
        }

        private static int ConvertFromUnixTimestamp(int created)
        {
            var origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var minAgo = (DateTime.UtcNow - origin.AddSeconds(created)).Minutes;
            return  minAgo < 0 ? 0 : minAgo;
        }
    }
}
