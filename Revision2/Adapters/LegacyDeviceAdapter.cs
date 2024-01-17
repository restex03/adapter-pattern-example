using Revision2;

namespace Revision2.Adapters;
public class LegacyDeviceAdapter : IConnectionAdapter
{

    private Revision2.Devices.LegacyDevice _legacyDevice;
    public LegacyDeviceAdapter(Revision2.Devices.LegacyDevice legacyDevice) {
        _legacyDevice = legacyDevice;
    }
    public void Recharge()
    {
        _legacyDevice.LegacyRecharge();
    }
}