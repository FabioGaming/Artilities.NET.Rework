using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace Artilities.Objects
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class DefaultResponse
    {
        public int statusCode { get; }
        public int executionTime { get; }
        public string english { get; }
        public string russian { get; }
        public string german { get; }
        public string json { get; }

        public DefaultResponse(JObject json)
        {
            string _identifier = "";
            dynamic jsonObj = (JObject)JsonConvert.DeserializeObject(json.ToString());
            if (jsonObj["generated_idea"] != null) { _identifier = "generated_idea"; } else { _identifier = "generated_challenge"; }
            this.json = json.ToString();
            try { statusCode = (int)jsonObj["status_code"]; } catch { }
            try { executionTime = (int)jsonObj["execution_time"]; } catch { }
            try { english = (string)jsonObj[_identifier]["eng"]; } catch { }
            try { russian = (string)jsonObj[_identifier]["ru"]; } catch { }
            try { german = (string)jsonObj[_identifier]["de"]; } catch { }

        }
    }
}
