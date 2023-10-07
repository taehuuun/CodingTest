int[] numbers = new int[10];

for (int i = 0; i < 5; i++)
{
    int input = int.Parse(Console.ReadLine());

    numbers[input]++;
}

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 1)
    {
        Console.WriteLine(i);
        return;
    }
}