namespace OVB.Demos.ShopDemo.Domain.CorporateContext.DataTransferObject;

public record Corporate
{
    public Guid ClientId { get; set; }
    public Guid ClientSecret { get; set; }

    public string CorrelationId { get; set; }
    public string SourcePlatform { get; set; }
    public string ExecutionUser { get; set; }
    public DateTime CreatedAt { get; set; }

    public string LastCorrelationKey { get; set; }
    public string LastSourcePlatformKey { get; set; }
    public string LastExecutionUserKey { get; set; }
    public DateTime LastModifiedAt { get; set; }

    public int TypeCorporate { get; set; }
    public string ComercialName { get; set; }
    public string SocialReason { get; set; }

    public bool IsCorporateEnabled { get; set; }
    public DateTime IsAvailableUntil { get; set; }
}
