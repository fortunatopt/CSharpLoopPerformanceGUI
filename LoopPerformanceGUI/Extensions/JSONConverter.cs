using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPerformanceGUI
{
    public static class JSONConverter
    {
        public static dynamic ConvertToDynamic(this string json)
        {
            if (json.IsValidJson() == false)
                return null;

            dynamic dynObject = JObject.Parse(json);
            return dynObject;
        }
        public static dynamic ConvertObjectToDynamic(this string json)
        {
            if (json.IsValidJsonObject() == false)
                return null;

            dynamic dynObject = JObject.Parse(json);
            return dynObject;
        }
        public static dynamic ConvertArrayToDynamic(this string json)
        {
            if (json.IsValidJsonArray() == false)
                return null;

            dynamic dynObject = JObject.Parse(json);
            return dynObject;
        }
    }
}
