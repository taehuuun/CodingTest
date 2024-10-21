int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (b < c)
{
    Console.WriteLine(c - b);
}
else if(b == c)
{
    Console.WriteLine(0);
}
else if(b > c)
{
    Console.WriteLine(a - b + c);
}