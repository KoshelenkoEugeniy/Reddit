using Reddit.Core.Data.Common;

namespace Reddit.Core.Helpers.Interfaces
{
    public interface IDeviceInfo
    {
        PlatformsEnum DeviceType { get; }
    }
}
