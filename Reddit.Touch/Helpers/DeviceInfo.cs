using System;
using Reddit.Core.Helpers.Interfaces;

namespace Reddit.Touch.Helpers
{
    public class DeviceInfo: IDeviceInfo
    {
        public string DeviceType => Type;

        public static string Type => "iOS";
    }
}
