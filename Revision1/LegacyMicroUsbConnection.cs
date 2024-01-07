namespace Revision1;

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

    public bool IsCharging() {
        return this.Device.IsCharging;
    }

}