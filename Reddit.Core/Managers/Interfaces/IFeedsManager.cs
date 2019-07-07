using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Reddit.Core.Data.Models;

namespace Reddit.Core.Managers.Interfaces
{
    public interface IFeedsManager
    {
        Task<List<FeedModel>> GetHomeFeeds();
    }
}
