var input = new int[] { };

while (true)
{
    input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    if (input[0] == 0 && input[1] == 0)
    {
        break;
    }

    if (input[0] + input[1] == 13)
    {
        Console.WriteLine("Never speak again.");
    }
    else if (input[0] < input[1])
    {
        Console.WriteLine("Left beehind.");
    }
    else if (input[0] > input[1])
    {
        Console.WriteLine("To the convention.");
    }
    else if (input[0] == input[1])
    {
        Console.WriteLine("Undecided.");
    }
}