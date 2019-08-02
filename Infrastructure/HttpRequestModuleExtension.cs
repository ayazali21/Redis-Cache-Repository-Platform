using Microsoft.AspNetCore.Builder;

namespace Platform.Redis.Infrastructure
{
    /// <summary>
    /// The class is extension to HTTPModule
    /// </summary>
    public static class HttpRequestModuleExtension
    {
        public static IApplicationBuilder RedisMiddleware(this IApplicationBuilder builder)
        {
            
            return builder.UseMiddleware<HttpRequestModule>();

        }
    }
}
