using Revision2.Connections;


namespace Revision2;
public class Mighty3WayLightningMicroUsbCCharger {

    private IEnumerable<IConnectionAdapter> _connections;

    public Mighty3WayLightningMicroUsbCCharger(
        IEnumerable<IConnectionAdapter> connections
    ) {
        _connections = connections;
    }


    public void Charge() {
        foreach (var connection in _connections) {
            connection.Recharge();
        }
    }

}