using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform;
using Reddit.Core.Helpers.Interfaces;
using Reddit.Touch.Helpers;

namespace Reddit.Touch
{
    public class Setup : MvxIosSetup
    {
        public Setup(IMvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
            : base(applicationDelegate, presenter)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override void InitializeIoC()
        {
            base.InitializeIoC();
            Mvx.RegisterType<IDeviceInfo, DeviceInfo>();
        }
    }
}
