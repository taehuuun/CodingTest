var sr = new StreamReader(Console.OpenStandardInput());
var nab = sr.ReadLine().Split().Select(int.Parse).ToArray();
var st = sr.ReadLine().Split().Select(int.Parse).ToArray();

var n = nab[0];
var a = nab[1];
var b = nab[2];
var s = st[0];
var t = st[1];

if (s > a && s < b && t > a && t < b)
{
    Console.WriteLine("City");
}
else if ((s <= a && t <= a) || (s >= b && t >= b))
{
    Console.WriteLine("Outside");
}
else
{
    Console.WriteLine("Full");
}