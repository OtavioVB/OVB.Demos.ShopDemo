using OVB.Demos.ShopDemo.Domain.CorporateContext.ENUMs;

namespace OVB.Demos.ShopDemo.Domain.CorporateContext.Entities.Base;

public abstract class CorporateBase
{
    public TypeCorporate Type { get; }

    protected CorporateBase(TypeCorporate type)
    {
        Type = type;
    }
}
