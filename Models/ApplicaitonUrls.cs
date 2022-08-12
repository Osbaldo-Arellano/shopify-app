using System.Text.RegularExpressions;

namespace AuntieDot.Models;

class ApplicaitonUrls : IApplicaitonUrls
{
    public ApplicaitonUrls(ISecrets secrets)
    {
        //OauthRedirectUrl = JoinUrls(secrets.HostDomain, "/shopify/authresult");
        //SubscriptionRedirectUrl = JoinUrls(secrets.HostDomain,"/subscription/chargeresult");
        //AppUninstalledWebhookUrl = JoinUrls(secrets.HostDomain, "/webhooks/app-uninstalled");
    }


    public string JoinUrls(string left, string right)
    {
        var trimTrailingSlash = new Regex("/+$");
        var trimLeadingSlash = new Regex("^/+");
        return trimTrailingSlash.Replace(left, "") + "/" +
               trimLeadingSlash.Replace(right, "");
    }
    
    
    
    
    public string OauthRedirectUrl { get; }
    public string SubscriptionRedirectUrl { get; }
    public string AppUninstalledWebhookUrl { get; }
}