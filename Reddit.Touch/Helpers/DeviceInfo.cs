using Reddit.Core.Data.Common;
using Reddit.Core.Helpers.Interfaces;

namespace Reddit.Touch.Helpers
{
    public class DeviceInfo: IDeviceInfo
    {
        public PlatformsEnum DeviceType => PlatformsEnum.iOS;
    }
}
