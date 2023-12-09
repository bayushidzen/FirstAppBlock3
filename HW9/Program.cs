using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace HW9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string json = "{\"Name\": 'Vasya','Age': 32,'City': 'Default','PetType':'cat','PetName':'Nika'}";

            var jsonObj = JsonConvert.DeserializeObject(json) as JObject;

            XDocument xmlDoc = new XDocument(new XElement("Root", jsonObj.Properties().Select(p => new XElement(p.Name, p.Value))));
            xmlDoc.Save("output.xml");
        }

    }

}
