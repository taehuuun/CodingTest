int n = int.Parse(Console.ReadLine());

int result = 0;

int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

for (int i = 0; i < n; i++)
{
    result += input[i];
}

if (result < 0)
{
    Console.WriteLine("Left");
}
else if (result == 0)
{
    Console.WriteLine("Stay");
}
else
{
    Console.WriteLine("Right");
}