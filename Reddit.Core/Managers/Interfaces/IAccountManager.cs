﻿using System;
using System.Threading.Tasks;
using Reddit.Core.Data.Dtos;
using Reddit.Core.Data.Models;

namespace Reddit.Core.Managers.Interfaces
{
    public interface IAccountManager
    {
        Task<UserModel> Login(string userName, string password);
    }
}
