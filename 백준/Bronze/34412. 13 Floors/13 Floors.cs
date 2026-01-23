var sr = new StreamReader(Console.OpenStandardInput());
int x = int.Parse(sr.ReadLine());

if (x <= 12)
{
    Console.WriteLine(x);
}
else
{
    Console.WriteLine(x + 1);
}