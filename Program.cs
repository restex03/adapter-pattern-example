using Revision1;
using Revision2;
using Revision2.Adapters;

public class Program {
	public static void Main()
	{
		// RunRevision1();
		RunRevision2();
	}

	public static void RunRevision2() {
		var iphone = new Revision2.Devices.IPhone();
		var iphoneConnectionAdapter = new IPhoneConnectionAdapter(iphone);

		var android = new Revision2.Devices.AndroidPhone();
		var AndroidConnectionAdapter = new AndroidConnectionAdapter(android);

		var legacyDevice = new Revision2.Devices.LegacyDevice();
		var legacyDeviceAdapter = new LegacyDeviceAdapter(legacyDevice);

		var connections = new List<IConnectionAdapter>() {
			iphoneConnectionAdapter,
			AndroidConnectionAdapter,
			legacyDeviceAdapter
		};
		var charger = new Revision2.Mighty3WayLightningMicroUsbCCharger(connections);

		charger.Charge();
	}

	public static void RunRevision1() {
	
		var iPhone = new Revision1.IPhone();
		var iPhoneConnection = new Revision1.LightningConnection(iPhone);

		var androidDevice = new Revision1.AndroidPhone();
		var usbcConnection = new Revision1.UsbcConnection(androidDevice);

		var charger = new Revision1.Mighty3WayLightningMicroUsbCCharger(iPhoneConnection, usbcConnection);
		charger.Charge();

	}

}

