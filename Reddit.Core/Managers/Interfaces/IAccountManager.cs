using System;
using Reddit.Core.Data.Dtos;
using Reddit.Core.Data.Models;

namespace Reddit.Core.Managers.Interfaces
{
    public interface IAccountManager
    {
        AccessModel GetAccessToken(string userName, string password);
    }
}
