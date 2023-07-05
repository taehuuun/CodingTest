while (true)
{
    string input = Console.ReadLine();
    string[] splitInput = input.Split(' ');

    float x = float.Parse(splitInput[0]);
    float y = float.Parse(splitInput[1]);

    if (x == 0 && y == 0)
    {
        Console.WriteLine("AXIS");
        return;
    }
    
    if (x == 0 || y == 0)
    {
        Console.WriteLine("AXIS");
    }
    else if (x > 0 && y > 0)
    {
        Console.WriteLine("Q1");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Q2");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Q3");
    }
    else
    {
        Console.WriteLine("Q4");
    }    
}