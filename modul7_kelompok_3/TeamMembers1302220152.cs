using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace modul7_kelompok_3
{
    internal class TeamMembers1302220152
    {
        public void ReadJson()
        {
            string jstxt = File.ReadAllText("../../../../jurnal7_2_1302220152.json"); // buka file

            var options = new JsonSerializerOptions { IncludeFields = true };
            Data js = JsonSerializer.Deserialize<Data>(jstxt, options); // parse json

            foreach (Member mb in js.members)
            {
                Console.WriteLine($"<{mb.nim}> <{mb.firstName} {mb.lastName}> ({mb.age} {mb.gender})");
            }
        }
    }
    class Data
    {
        public Member[] members;
    }
    class Member
    {
        public string firstName;
        public string lastName;
        public string gender;
        public int age;
        public string nim;
    }
}
