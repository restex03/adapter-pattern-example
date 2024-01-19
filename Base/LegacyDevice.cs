using System.Data;

namespace Domain;
public sealed class LegacyDevice : IIncompatibleDevice {

    public bool IsCharging { get; private set; } = false;
    private bool _connected { get; set; } = false;

    public void Connect() {
        Console.WriteLine($"{nameof(LegacyDevice)} is now connected.");
        this._connected = true;
    }

    public void LegacyRecharge() {
        Console.WriteLine($"{nameof(LegacyDevice)} is now charging.");
        this.IsCharging = true;
    }

}

