namespace AuntieDot.Models;

// Shopify will use this class to authenticate a user
// Checks database to verify that Token matches user session. 
public class OauthState
{
    // Database ID
    public int Id { get; set; }
    
    public DateTimeOffset DateCreated { get; set; }
    
    public string Token { get; set; }
}