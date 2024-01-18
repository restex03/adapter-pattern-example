namespace Domain;

public sealed class DeviceConnection {
    private IDevice Device { get; set; }

    public DeviceConnection(IDevice device) {
        this.Device = device;
        this.Device.EstablishConnection();
    }

    public void Recharge() {
            if (this.Device is null || !this.Device.IsConnected) {
                Console.WriteLine("Please connect a device to begin recharging.");
                return;
            }

        this.Device.Recharge();
    } 

}