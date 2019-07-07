using System;
using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using MvvmCross.Platform;
using Reddit.Core.Helpers.Interfaces;
using Reddit.Droid.Helpers;

namespace Reddit.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Reddit.Core.App();
        }

        protected override void InitializeIoC()
        {
            base.InitializeIoC();
            Mvx.RegisterType<IDeviceInfo, DeviceInfo>();
        }
    }
}
