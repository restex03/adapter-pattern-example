
namespace EnWikiEx;
public sealed class AndroidPhone : IUsbPhone
{
	private bool isConnected;
	
	public void ConnectUsb()
	{
		this.isConnected = true;
		Console.WriteLine("Android phone connected.");
	}

	public void Recharge()
	{
		if (this.isConnected)
		{
			Console.WriteLine("Android phone recharging.");
		}
		else
		{
			Console.WriteLine("Connect the USB cable first.");
		}
	}
}