using System;
using System.Net;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;
using Polly;
using Polly.Fallback;
using Polly.Timeout;
using Polly.Wrap;
using Reddit.Core.Services.Interfaces;

namespace Reddit.Core.Services
{
    public class BaseService
    {
        public IApiService ApiService { get; private set; }
        public IMvxTrace Logger { get; private set; }

        public BaseService()
        {
            ApiService = Mvx.Resolve<IApiService>();
            Logger = Mvx.Resolve<IMvxTrace>();
        }
    }
}
