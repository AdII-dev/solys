// See https://aka.ms/new-console-template for more information

using solys;
using System.Numerics;

List<Adat> adatok = new();
using StreamReader sr = new(
    path: @"..\..\..\SRC\solsys.txt",
    encoding: System.Text.Encoding.UTF8);
while (!sr.EndOfStream) adatok.Add(new Adat(sr.ReadLine()));

Console.WriteLine(adatok.Count());

Console.WriteLine("1.");
Console.WriteLine($"\t{adatok.Count} db bolygü van a naprendszerben\n");

Console.WriteLine("2.");
var f2 = adatok.Average(x => x.HoldSzam);
Console.WriteLine($"\tA naprendszer egy bolgyójának átlegosan {f2} db holdja van\n");

Console.WriteLine("3.");
var f3 = adatok.OrderByDescending(p => p.BolygTerfog)
                         .First();
Console.WriteLine($"\tA legnagyobb bolygó a {f3.Bolygo}");

Console.Write("4. Írd be a keresett bolygó nevét: ");
string bn = Console.ReadLine();
bool f4 = false;
foreach (Adat adat in adatok)
{
    if (adat.Bolygo == bn) f4 = !f4;
}
if (f4) Console.WriteLine("\tMegtalálható a listában a keresett bolygó");
else Console.WriteLine("\tNem található meg a listában a keresett bolgyó");

Console.Write("5. Írj be egy egész számot: ");
int esz = Convert.ToInt32(Console.ReadLine());
bool f5 = false;
foreach (Adat adat in adatok)
{
    if (adat.HoldSzam > esz) f5 = !f5;
}
if (f5) Console.WriteLine($"\tA következő bolygóknak van {esz}-nél/nál több holdja:");
else Console.WriteLine("Nincsen a keresettnek megfelelő bolygó");
Console.ReadKey(); 
