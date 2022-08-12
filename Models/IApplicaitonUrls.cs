namespace AuntieDot.Models;

public interface IApplicaitonUrls
{
    string OauthRedirectUrl { get; }
    string SubscriptionRedirectUrl { get; }
    string AppUninstalledWebhookUrl { get; }
}