using Modifications.Adapters.Implementation_01;

public class Program {
	public static void Main()
	{
		RunBaseImplementation();
		RunAdapterImplementation_01();
		RunWikipediaAdapterExample();
	}

	/// <summary>
	/// Here you can see from a high-level how LegacyDeviceAdapter is used to include 
	/// LegacyDevice in the list of DeviceConnection that is compatible with 
	/// the Charger class. 
	/// </summary>
	public static void RunAdapterImplementation_01() {
		Console.WriteLine("\n\n * * * * * * * * * * * * * * * * *");
		Console.WriteLine($"Running {nameof(RunAdapterImplementation_01)}()");

		var iphone = new Base.IPhone();
		var iPhoneConnection = new Base.DeviceConnection(iphone);

		var android = new Base.AndroidPhone();
		var androidConnection = new Base.DeviceConnection(android);

		var legacyDevice = new Base.LegacyDevice();
		// Here is how this implementation uses an adapter
		var legacyDeviceAdapter = new LegacyDeviceAdapter(legacyDevice);
		var legacyConnection = new Base.DeviceConnection(legacyDeviceAdapter);

		var connections = new List<Base.DeviceConnection>() {
			iPhoneConnection,
			androidConnection,
			legacyConnection
		};
		var charger = new Base.Charger(connections);

		charger.Charge();
	}


	/// <summary>
	/// See here the base implementation, where LegacyDevice cannot be used
	/// since it is not compatible with the IDevice interface. 
	/// </summary>
	public static void RunBaseImplementation() {
		Console.WriteLine("\n\n * * * * * * * * * * * * * * * * *");
		Console.WriteLine($"Running {nameof(RunBaseImplementation)}()");

		var iPhone = new Base.IPhone();
		var androidDevice = new Base.AndroidPhone();

		var connections = new List<Base.DeviceConnection>() {
			new Base.DeviceConnection(iPhone),
			new Base.DeviceConnection(androidDevice)
		};

		var charger = new Base.Charger(connections);
		charger.Charge();

	}

	/// <summary>
	/// Here is the example I found on Wikipedia at the time of writing. See 
	/// readme.md for link. 
	/// </summary>
	public static void RunWikipediaAdapterExample() {
		Console.WriteLine("\n\n * * * * * * * * * * * * * * * * *");
		Console.WriteLine($"Running {nameof(RunBaseImplementation)}()");
        
        EnWikiEx.ILightningPhone applePhone = new EnWikiEx.ApplePhone();
		EnWikiEx.IUsbPhone adapterCable = new EnWikiEx.LightningToUsbAdapter(applePhone);
		adapterCable.ConnectUsb();
		adapterCable.Recharge();
	}

}

