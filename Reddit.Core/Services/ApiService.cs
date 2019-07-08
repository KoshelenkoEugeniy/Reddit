using MvvmCross.Platform;
using Reddit.Core.Services.Interfaces;

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
