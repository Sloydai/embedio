using System.Net.Http;

namespace EmbedIO.Testing.Internal
{
    internal static class AdditionalHttpMethods
    {
        public static readonly HttpMethod Patch = new HttpMethod("PATCH");
    }
}