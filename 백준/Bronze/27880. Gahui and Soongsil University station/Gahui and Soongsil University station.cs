int depth = 0;

for (int i = 0; i < 4; i++)
{
    string input = Console.ReadLine();
    string[] splitInput = input.Split(' ');
    
    if (splitInput[0] == "Es")
    {
        depth += int.Parse(splitInput[1]) * 21;
    }
    else
    {
        depth += int.Parse(splitInput[1]) * 17;
    }
}

Console.WriteLine(depth);