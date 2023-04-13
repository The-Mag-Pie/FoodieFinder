namespace FoodieFinder.Auth0
{
    internal class Auth0ClientOptions
    {
        public string Domain { get; set; }
        public string ClientId { get; set; }
        public string RedirectUri { get; set; }
        public string Scope { get; set; }
        public IdentityModel.OidcClient.Browser.IBrowser Browser { get; set; }

        public Auth0ClientOptions()
        {
            Scope = "openid email";
            RedirectUri = "myapp://callback";
            Browser = new WebBrowserAuth();
        }
    }
}
