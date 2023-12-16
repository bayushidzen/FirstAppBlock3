using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace HW9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string json = "{\"VDD\": '44',\"REAL\": 0,\"Perem\": 1,\"ID\": \"_6QI0HB878014\",\"ND\": \"31426\",\"DD\": \"2023-10-16T00:00:00\",\"ORGANIZ\": 1,\"ORG_1C\": \"000002575\",\"CM_1C\": \"00000057345\"}";

            var jsonObj = JsonConvert.DeserializeObject(json) as JObject;

            XDocument xmlDoc = new XDocument(new XElement("Root", jsonObj.Properties().Select(p => new XElement(p.Name, p.Value))));
            xmlDoc.Save("output.xml");
        }
    }
}
