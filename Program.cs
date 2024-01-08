using Revision1;
using Revision2;

public class Program {
	public static void Main()
	{
		// RunRevision1();
		RunRevision2();
	}

	public static void RunRevision2() {

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

