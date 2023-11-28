while (true)
{
    string input = Console.ReadLine();

    if (input == "0")
    {
        return;
    }

    int width = 2 + input.Length-1;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == '1')
        {
            width += 2;
        }
        else if (input[i] == '0')
        {
            width += 4;
        }
        else
        {
            width += 3;
        }
    }
    
    Console.WriteLine(width);
}