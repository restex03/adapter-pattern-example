using Domain;

namespace Modifications.Adapters.Implementation_01;
public class LegacyDeviceAdapter : IDevice
{
    public bool IsConnected { get; private set;}
    private IIncompatibleDevice _legacyDevice;
    public LegacyDeviceAdapter(IIncompatibleDevice legacyDevice) {
        _legacyDevice = legacyDevice;
    }

    public void EstablishConnection() {
        Console.WriteLine($"{nameof(LegacyDeviceAdapter)} connected.");
        _legacyDevice.Connect();
        IsConnected = true;
    }
    public void Recharge()
    {
        _legacyDevice.LegacyRecharge();
    }
}