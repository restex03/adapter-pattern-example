using Modifications.Adapters.Implementation_01;

public class Program {
	public static void Main()
	{
		ExistingImplementation();
		AdapterImplementation_01();
		
	}

	public static void AdapterImplementation_01() {
		Console.WriteLine("\n\n * * * * * * * * * * * * * * * * *");
		Console.WriteLine($"Running {nameof(AdapterImplementation_01)}()");

		var iphone = new Domain.IPhone();
		var iPhoneConnection = new Domain.DeviceConnection(iphone);

		var android = new Domain.AndroidPhone();
		var androidConnection = new Domain.DeviceConnection(android);

		var legacyDevice = new Domain.LegacyDevice();
		// Here is how this implementation uses an adapter
		var legacyDeviceAdapter = new LegacyDeviceAdapter(legacyDevice);
		var legacyConnection = new Domain.DeviceConnection(legacyDeviceAdapter);

		var connections = new List<Domain.DeviceConnection>() {
			iPhoneConnection,
			androidConnection,
			legacyConnection
		};
		var charger = new Domain.Charger(connections);

		charger.Charge();
	}

	public static void ExistingImplementation() {
		Console.WriteLine("\n\n * * * * * * * * * * * * * * * * *");
		Console.WriteLine($"Running {nameof(ExistingImplementation)}()");

		var iPhone = new Domain.IPhone();
		var androidDevice = new Domain.AndroidPhone();

		var connections = new List<Domain.DeviceConnection>() {
			new Domain.DeviceConnection(iPhone),
			new Domain.DeviceConnection(androidDevice)
		};

		var charger = new Domain.Charger(connections);
		charger.Charge();

	}

	public static void RunWikipediaAdapterExample() {
		Console.WriteLine("\n\n * * * * * * * * * * * * * * * * *");
		Console.WriteLine($"Running {nameof(ExistingImplementation)}()");
        
        EnWikiEx.ILightningPhone applePhone = new EnWikiEx.ApplePhone();
		EnWikiEx.IUsbPhone adapterCable = new EnWikiEx.LightningToUsbAdapter(applePhone);
		adapterCable.ConnectUsb();
		adapterCable.Recharge();
	}

}

