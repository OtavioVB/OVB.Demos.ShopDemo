namespace OVB.Demos.ShopDemo.WebApi.Controllers.Payloads;

public readonly struct AuthorizationCorporateCodePayloadInput
{
    public AuthorizationCorporateCodePayloadInput(
        string state, 
        string grantType, 
        string scope)
    {
        State = state;
        GrantType = grantType;
        Scope = scope;
    }

    public string State { get; init; }
    public string GrantType { get; init; }
    public string Scope { get; init; }
}
