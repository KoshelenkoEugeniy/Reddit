using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using Reddit.Core.Managers;
using Reddit.Core.Managers.Interfaces;
using Reddit.Core.Services;
using Reddit.Core.Services.Interfaces;

namespace Reddit.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.RegisterType<IApiService, ApiService>();
            Mvx.RegisterSingleton<IRedditApi>(() => new RedditApi());

            Mvx.RegisterType<IFeedsService, FeedsService>();
            Mvx.RegisterType<IAccountService, AccountService>();

            Mvx.RegisterType<IAccountManager, AccountManager>();
            Mvx.RegisterType<IFeedsManager, FeedsManager>();

            RegisterNavigationServiceAppStart<ViewModels.FeedViewModel>();
        }
    }
}
