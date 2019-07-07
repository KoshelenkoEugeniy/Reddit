using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Reddit.Core.Data.Mappers;
using Reddit.Core.Data.Models;
using Reddit.Core.Managers.Interfaces;
using Reddit.Core.Services.Interfaces;

namespace Reddit.Core.Managers
{
    public class FeedsManager: IFeedsManager
    {
        private IFeedsService _feedsService;

        public FeedsManager(IFeedsService feedsService)
        {
            _feedsService = feedsService;
        }

        public async Task<List<FeedModel>> GetHomeFeeds()
        {
            var homeFeeds = await _feedsService.GetHomeFeeds();

            if(homeFeeds != null && homeFeeds.data.children.Length > 0)
            {
                List<FeedModel> feeds = new List<FeedModel>();

                foreach(var feed in homeFeeds.data.children)
                {
                    var feedDto = feed.data;
                    feeds.Add(feedDto.DataToModel());
                }

                return feeds;
            }
            else
            {
                return null;
            }
        }
    }
}
