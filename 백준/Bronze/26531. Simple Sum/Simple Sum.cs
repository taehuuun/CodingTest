string[] input = Console.ReadLine().Split(' ');

if (int.Parse(input[0]) + int.Parse(input[2]) == int.Parse(input[4]))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}