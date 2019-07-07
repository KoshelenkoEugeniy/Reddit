using System;
using System.Net.Http;
using System.Net.Http.Headers;
using MvvmCross.Platform;
using Reddit.Core.Managers;
using Reddit.Core.Services.Interfaces;
using Refit;

namespace Reddit.Core.Services
{
    public class ApiService: IApiService
    { 
        public IRedditApi Client         {
            get             {
                return Mvx.Resolve<IRedditApi>();
            }
        }
    }
}
