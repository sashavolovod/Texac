using Texac.Net;

namespace Texac
{
    public static class TexacApi
    {
        public static TexacApiClient Client { get; private set; }

        public static void Init()
        {
            if (Client != null) return;
            Client = new TexacApiClient(Properties.Settings.Default.api_path);
        }
    }
}