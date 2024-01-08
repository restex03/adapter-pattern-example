using Revision2.Devices;

namespace Revision2.Connections;

public class LegacyMicroUsbConnection {
    private LegacyDevice Device { get; set; }

    public LegacyMicroUsbConnection(LegacyDevice device) {
        this.Device = device;
        this.Device.EstablishConnection();
    }

    public void Recharge() {
        if (this.Device is null || !this.Device.IsConnected) {
            Console.WriteLine("Please connect a device to begin recharging.");
            return;
        }

        this.Device.LegacyRecharge();
    } 

}