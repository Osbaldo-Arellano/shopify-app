namespace AuntieDot.Models;

public interface ISecrets
{
    public string ShopifySecretKey { get; }
    
    public string ShopifyPublicKey { get; }
    
    //public string HostDomain { get; }
}