using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace modul7_kelompok_3
{
    internal class DataMahasiswa1302220152
    {
        public void ReadJson()
        {
            string jstxt = File.ReadAllText("../../../../jurnal7_1_1302220152.json"); // buka file

            var options = new JsonSerializerOptions{ IncludeFields =  true };
            Data js = JsonSerializer.Deserialize<Data>(jstxt, options); // parse json

            Console.WriteLine($"{js.firstName} {js.lastName} {js.gender} {js.address["streetAddress"]} {js.address["city"]} {js.address["state"]}");
            foreach (Dictionary<string, string> dct in js.courses)
            {
                Console.WriteLine(dct["code"] + " " + dct["name"]);
            }
        }
    }

    class Data
    {
        public string firstName;
        public string lastName;
        public int age;
        public string gender;
        public Dictionary<string, string> address;
        public Dictionary<string, string>[] courses;

    }
}
