// See https://aka.ms/new-console-template for more information
using modul7_kelompok_3;

Console.WriteLine("data mahasiswa");

DataMahasiswa1302220152 dthaidar = new DataMahasiswa1302220152();
dthaidar.ReadJson();

Console.WriteLine();
Console.WriteLine("member tim");

TeamMembers1302220152 tm = new TeamMembers1302220152();
tm.ReadJson();
