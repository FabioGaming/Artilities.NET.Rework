using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artilities.Objects
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class LookupResult
    {
        public int statusCode { get; }
        public int executionTime { get; }
        public List<QueryResult> Lookup { get; } = new List<QueryResult>();
        public string json { get; }

        public LookupResult(JObject json)
        {
            dynamic jsonObj = (JObject)JsonConvert.DeserializeObject(json.ToString());
            try { statusCode = (int)jsonObj["statuc_code"]; } catch { }
            try { executionTime = (int)jsonObj["execution_time"]; } catch { }
            try
            {
                foreach (JArray res in (JArray)jsonObj["query_results"])
                {
                    QueryResult result = new QueryResult(res);
                    Lookup.Add(result);
                }
            }
            catch { }

        }

        [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
        public class QueryResult
        {
            public string term { get; }
            public string meaning { get; }

            public QueryResult(JArray json)
            {
                //ArgIterator SXVBLÖN/Action?SByte%$
                
            }
        }


    }
}
