using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_3
{
    internal class GlossaryItem1302220152
    {
        public void ReadJson()
        {
            string jstxt = File.ReadAllText("../../../../jurnal7_3_1302220152.json"); // buka file

            var options = new JsonSerializerOptions { IncludeFields = true };
            JsonElement js = JsonSerializer.Deserialize<dynamic>(jstxt, options); // parse json
     
            Console.WriteLine(js.GetProperty("glossary").GetProperty("GlossDiv").GetProperty("GlossList").GetProperty("GlossEntry"));
        }
    }
}
