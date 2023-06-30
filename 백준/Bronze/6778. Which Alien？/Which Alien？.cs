int antenna = int.Parse(Console.ReadLine());
int eye = int.Parse(Console.ReadLine());

if (antenna >= 3 && eye <= 4)
{
    Console.WriteLine("TroyMartian");
}
if (antenna <= 6 && eye >= 2)
{
    Console.WriteLine("VladSaturnian");
}
if (antenna <= 2 && eye <= 3)
{
    Console.WriteLine("GraemeMercurian");
}