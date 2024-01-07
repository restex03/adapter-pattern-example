namespace Revision1;

public class Mighty3WayLightningMicroUsbCCharger {

    private LightningConnection? LightningConnection {get; set;} = null;
    private LegacyMicroUsbConnection? LegacyMicroUsbConnection {get; set;} = null;
    private UsbcConnection? UsbcConnection {get; set;} = null;

    public Mighty3WayLightningMicroUsbCCharger(
        LightningConnection? lightningConnection = null, 
        LegacyMicroUsbConnection? legacyMicroUsbConnection = null, 
        UsbcConnection? usbcConnection = null
    ) {
        this.LightningConnection = lightningConnection;
        this.LegacyMicroUsbConnection = legacyMicroUsbConnection;
        this.UsbcConnection = usbcConnection;
    }


    public void Charge() {
        this.LightningConnection?.Recharge();
        this.UsbcConnection?.Recharge();
        this.LegacyMicroUsbConnection?.Recharge();
    }

}