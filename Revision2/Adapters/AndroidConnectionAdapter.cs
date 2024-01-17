using Revision2;

namespace Revision2.Adapters;
public class AndroidConnectionAdapter : IConnectionAdapter
{

    private Revision2.Devices.AndroidPhone _android;
    public AndroidConnectionAdapter(Revision2.Devices.AndroidPhone android) {
        _android = android;
    }
    public void Recharge()
    {
        _android.Recharge();
    }
}