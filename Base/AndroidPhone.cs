using System.Data;

namespace Domain;

public sealed class AndroidPhone : IDevice {

    public bool IsConnected { get; private set; } = false;
    public bool IsCharging { get; private set; } = false;


    public void EstablishConnection() {
        Console.WriteLine($"{nameof(AndroidPhone)} connected.");
        this.IsConnected = true;
    }

    public void Recharge() {
        Console.WriteLine($"{nameof(AndroidPhone)} charging.");
        this.IsCharging = true;
    }

}