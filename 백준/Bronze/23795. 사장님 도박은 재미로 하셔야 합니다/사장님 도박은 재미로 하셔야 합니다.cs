int total = 0;

while (true)
{
    int input = int.Parse(Console.ReadLine());
    if (input < 0)
    {
        break;
    }

    total += input;
}

Console.WriteLine(total);