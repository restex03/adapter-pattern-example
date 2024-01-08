using System.Data;

namespace Revision1;

public sealed class IPhone {

    public bool IsConnected { get; private set; } = false;
    public bool IsCharging { get; private set; } = false;


    public void EstablishConnection() {
        Console.WriteLine($"{nameof(IPhone)} connected.");
        this.IsConnected = true;
    }

    public void Recharge() {
        Console.WriteLine($"{nameof(IPhone)} charging.");
        this.IsCharging = true;
    }

}