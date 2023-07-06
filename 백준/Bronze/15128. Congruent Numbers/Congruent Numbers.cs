string[] input = Console.ReadLine().Split();

int p1 = int.Parse(input[0]);
int q1 = int.Parse(input[1]);
int p2 = int.Parse(input[2]);
int q2 = int.Parse(input[3]);

double result = (0.5 * p1 / q1 * p2 / q2);

if (Math.Floor(result).Equals(result))
{
    Console.WriteLine("1");
}
else
{
    Console.WriteLine("0");
}