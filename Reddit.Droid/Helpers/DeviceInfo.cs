using Reddit.Core.Data.Common;
using Reddit.Core.Helpers.Interfaces;

namespace Reddit.Droid.Helpers
{
    public class DeviceInfo: IDeviceInfo
    {
        public PlatformsEnum DeviceType => PlatformsEnum.Droid;
    }
}
