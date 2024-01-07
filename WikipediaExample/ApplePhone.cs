namespace WikipediaAdapterExample;


public sealed class ApplePhone : ILightningPhone
{
	private bool isConnected;
	
	public void ConnectLightning()
	{
		this.isConnected = true;
		Console.WriteLine("Apple phone connected.");
	}

	public void Recharge()
	{
		if (this.isConnected)
		{
			Console.WriteLine("Apple phone recharging.");
		}
		else
		{
			Console.WriteLine("Connect the Lightning cable first.");
		}
	}
}