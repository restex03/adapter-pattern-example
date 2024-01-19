namespace Base;

public sealed class Charger {

    private List<DeviceConnection> Connections { get; set; }

    public Charger(IEnumerable<DeviceConnection> connections) {
        this.Connections = connections.ToList();
    }


    public void Charge() {
        this.Connections.ForEach(x => x.Recharge());
    }

}