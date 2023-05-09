using Newtonsoft.Json.Linq;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;

namespace Artilities
{
    public class ArtilitiesClient
    {
        //public string APIKey { get; private set; }
        //public string discordId { get; private set; }

        public bool ignoreNonOK { get; set; } = false;

        private HttpClient client;
        private Dictionary<string, string> headers;

        /// <summary>
        /// This Object represents the main ArtilitiesClient for your Project
        /// </summary>
        public ArtilitiesClient(/*string apiKey = null, string discordId = null*/)
        {
            Version libVersion = Assembly.GetExecutingAssembly().GetName().Version;
            //APIKey = apiKey;
            //this.discordId = discordId;
            client = new HttpClient();
            client.BaseAddress = new Uri("https://artilities-web-api.vercel.app");
            headers = new Dictionary<string, string>();
            headers.Add("Accept", "application/json");
            headers.Add("User-Agent", $"Artilities.NET {libVersion.Major}.{libVersion.Minor}.{libVersion.Revision}");
            foreach(KeyValuePair<string,string> header in headers)
            {
                client.DefaultRequestHeaders.Add(header.Key, header.Value);
            }
        }

        /// <summary>
        /// This function allows you to get an Art Idea from the Artilities Database
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Objects.DefaultResponse GetIdea()
        {
            try
            {
                var res = client.GetAsync("/api/ideas").Result;
                if((int)res.StatusCode != 200) { if (!ignoreNonOK) { throw new Exception(res.Content.ReadAsStringAsync().Result); } }
                Objects.DefaultResponse idea = new Objects.DefaultResponse(JObject.Parse(res.Content.ReadAsStringAsync().Result));
                return idea;
            }
            catch(Exception e) { throw new Exception(e.Message); }
        }

        /// <summary>
        /// This function allows you to get an Art Challenge from the Artilities Database
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Objects.DefaultResponse GetChallenge()
        {
            try
            {
                var res = client.GetAsync("/api/challenges").Result;
                if((int)res.StatusCode != 200) { if(!ignoreNonOK) { throw new Exception(res.Content.ReadAsStringAsync().Result); } }
                Objects.DefaultResponse challenge = new Objects.DefaultResponse(JObject.Parse(res.Content.ReadAsStringAsync().Result));
                return challenge;
            }catch(Exception e) { throw new Exception(e.Message); }
        }

       
    }
}