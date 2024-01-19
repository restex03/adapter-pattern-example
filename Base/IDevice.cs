namespace Base;

public interface IDevice {
    public void EstablishConnection();
    public void Recharge();
    public bool IsConnected { get; }
}