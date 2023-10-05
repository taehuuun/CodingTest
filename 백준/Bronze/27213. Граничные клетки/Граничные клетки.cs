int w = int.Parse(Console.ReadLine());
int h = int.Parse(Console.ReadLine());

if (w < 3 || h < 3)
{
    Console.WriteLine(w * h);
}
else
{
    Console.WriteLine((w - 2)*2 +(h - 2)*2 + 4);
}