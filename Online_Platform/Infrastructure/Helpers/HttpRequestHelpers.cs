namespace Online_Platform.Infrastructure.Helpers
{
    using Microsoft.AspNetCore.Http;

    public class HttpRequestHelpers
    {
        public static string GetRequestUrl(HttpRequest req)
            => $"{req.Scheme}://{req.Host.Value}{req.Path.Value}";
    }
}
