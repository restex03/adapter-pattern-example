using Domain;
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

		var iphone = new IPhone();
		var iPhoneConnection = new DeviceConnection(iphone);

		var android = new AndroidPhone();
		var androidConnection = new DeviceConnection(android);

		var legacyDevice = new LegacyDevice();
		// Here is how this implementation uses an adapter
		var legacyDeviceAdapter = new LegacyDeviceAdapter(legacyDevice);
		var legacyConnection = new DeviceConnection(legacyDeviceAdapter);

		var connections = new List<DeviceConnection>() {
			iPhoneConnection,
			androidConnection,
			legacyConnection
		};
		var charger = new Charger(connections);

		charger.Charge();
	}

	public static void ExistingImplementation() {
		Console.WriteLine("\n\n * * * * * * * * * * * * * * * * *");
		Console.WriteLine($"Running {nameof(ExistingImplementation)}()");

		var iPhone = new IPhone();
		var androidDevice = new AndroidPhone();

		var connections = new List<DeviceConnection>() {
			new DeviceConnection(iPhone),
			new DeviceConnection(androidDevice)
		};

		var charger = new Charger(connections);
		charger.Charge();

	}

}

