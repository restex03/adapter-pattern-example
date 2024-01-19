using Base;

namespace Modifications.Adapters.Implementation_01;

/// <summary>
/// This class implements the Adapter Pattern to make LegacyDevice 
/// compatible with the IDevice interface used by the IPhone 
/// and AndroidPhone classes.
/// </summary>
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