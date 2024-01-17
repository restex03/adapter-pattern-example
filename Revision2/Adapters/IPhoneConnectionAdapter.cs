using Revision2;

namespace Revision2.Adapters;
public class IPhoneConnectionAdapter : IConnectionAdapter
{

    private Revision2.Devices.IPhone _iPhone;
    public IPhoneConnectionAdapter(Revision2.Devices.IPhone iPhone) {
        _iPhone = iPhone;
    }
    public void Recharge()
    {
        _iPhone.Recharge();
    }
}