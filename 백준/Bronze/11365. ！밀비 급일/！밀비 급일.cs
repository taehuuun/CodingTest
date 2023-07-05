while (true)
{
    string input = Console.ReadLine();

    if (input == "END")
    {
        return;
    }

    for (int i = input.Length - 1; i >= 0; i--)
    {
        Console.Write(input[i]);
    }
    Console.WriteLine();
}