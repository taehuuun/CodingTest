while (true)
{
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        return;
    }
    
    Console.WriteLine(input);
}