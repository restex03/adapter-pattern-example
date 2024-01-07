
using WikipediaAdapterExample;
using Revision1;

public class Program {
	public static void Main()
	{
		// RunWikipediaAdapterExample();
		RunRevision1();
	}

	public static void RunRevision1() {
	
		var iPhone = new Revision1.IPhone();
		var iPhoneConnection = new LightningConnection(iPhone);

		var androidDevice = new Revision1.AndroidPhone();
		var usbcConnection = new Revision1.UsbcConnection(androidDevice);

		var legacyDevice = new LegacyDevice();
		var microUsbConnection = new Revision1.LegacyMicroUsbConnection(legacyDevice);

		var charger = new Mighty3WayLightningMicroUsbCCharger(iPhoneConnection, microUsbConnection, usbcConnection);
		charger.Charge();

	}


	public static void RunWikipediaAdapterExample() {
		Console.WriteLine("Running Adapter Pattern project...");
        
        ILightningPhone applePhone = new ApplePhone();
		IUsbPhone adapterCable = new LightningToUsbAdapter(applePhone);
		adapterCable.ConnectUsb();
		adapterCable.Recharge();
	}
}

