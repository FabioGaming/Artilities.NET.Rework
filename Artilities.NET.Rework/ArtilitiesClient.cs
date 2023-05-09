using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;

namespace Artilities
{
    public class ArtilitiesClient
    {
        public string APIKey { get; private set; }
        public string discordId { get; private set; }

        public bool ignoreNonOK { get; set; } = false;

        private HttpClient client;
        public Dictionary<string, string> headers;

        public ArtilitiesClient(string apiKey = null, string discordId = null)
        {
            Version libVersion = Assembly.GetExecutingAssembly().GetName().Version;
            APIKey = apiKey;
            this.discordId = discordId;
            client = new HttpClient();
            client.BaseAddress = new Uri("https://artilities-web-api.vercel.app");
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("User-Agent", $"Artilities.NET@{libVersion.Major}.{libVersion.Minor}.{libVersion.Revision}");
            headers = client.DefaultRequestHeaders.ToDictionary<string,string>();
            
            
        }


        public void GetIdea()
        {
            try
            {

            }catch(Exception e) { throw new Exception(e.Message); }
        }
    }
}