long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

if (input[1] == 0)
{
    Console.WriteLine("0");
    return;
}

Console.WriteLine($"{(input[0] >= input[1] ? input[1] : input[0]+1)}");