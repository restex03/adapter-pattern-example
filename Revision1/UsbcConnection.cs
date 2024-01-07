namespace Revision1 {
    public class UsbcConnection {
        private AndroidPhone Device { get; set; }

        public UsbcConnection(AndroidPhone device) {
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

        public bool IsCharging() {
            return this.Device.IsCharging;
        }

    }
}

