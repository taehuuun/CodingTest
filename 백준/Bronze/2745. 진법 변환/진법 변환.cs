string[] input = Console.ReadLine().Split();

int digit = 0;

for (int i =0; i < input[0].Length; i++)
{
    if (char.IsDigit(input[0][i]))
    {
        digit = digit * int.Parse(input[1]) + input[0][i] - '0';
    }
    else
    {
        digit = digit * int.Parse(input[1]) + (input[0][i] - 'A' + 10);
    }
}

Console.WriteLine(digit);