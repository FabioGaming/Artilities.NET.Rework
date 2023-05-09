using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace Artilities.Objects
{
    public class DefaultResponse
    {
        public int statusCode { get; }
        public int executionTime { get; }
        public string english { get; }
        public string russian { get; }
        public string german { get; }

        public DefaultResponse(JObject json)
        {

        }
    }
}
