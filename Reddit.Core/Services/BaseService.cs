using MvvmCross.Platform;
using Reddit.Core.Services.Interfaces;

namespace Reddit.Core.Services
{
    public class BaseService
    {
        public IApiService ApiService { get; private set; }

        public BaseService()
        {
            ApiService = Mvx.Resolve<IApiService>();
        }
    }
}
