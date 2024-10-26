int[] numbers = new int[10];

int n = int.Parse(Console.ReadLine());
int[] input = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), int.Parse);

for (int i = 0; i < input.Length; i++)
{
    numbers[input[i]]++;
}

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        Console.WriteLine(i);
    }
}