while (true)
{
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
        return;

    string result = "";
    
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == 'i')
        {
            result += 'e';
        }
        else if (input[i] == 'e')
        {
            result += 'i';
        }
        else if (input[i] == 'I')
        {
            result += 'E';
        }
        else if (input[i] == 'E')
        {
            result += 'I';
        }
        else
        {
            result += input[i];
        }
    }
    
    Console.WriteLine($"{result}");
}