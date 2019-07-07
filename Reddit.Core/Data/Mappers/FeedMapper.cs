using System;
using Reddit.Core.Data.Dtos;
using Reddit.Core.Data.Models;

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

            model.AuthorName = data.author;
            model.Group = data.subreddit_name_prefixed;
            model.PostType = data.post_hint;
            model.Created = ConvertFromUnixTimestamp((int)data.created);
            model.Thumbnail = data.thumbnail;
            model.Title = data.title;
            model.TotalAwards = data.total_awards_received;
            model.Url = data.url;

            return model;
        }

        private static DateTime ConvertFromUnixTimestamp(int created)
        {
            var origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return origin.AddSeconds(created);
        }
    }
}
