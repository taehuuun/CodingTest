int[] range = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
int[] info = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

int rangeMin = range[0];
int rangeMax = range[1];
int solveValue = info[0];
int standard = info[1];
int count = 0;

for (int i = rangeMin; i <= rangeMax; i++)
{
    if(solveValue - standard > i || solveValue + standard < i)
    {
        continue;
    }
    
    count++;
}

if (count == 0)
{
    Console.WriteLine("IMPOSSIBLE");
}
else
{
    Console.WriteLine(count);
}