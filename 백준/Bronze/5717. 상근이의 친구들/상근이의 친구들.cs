while (true)
{
    string input = Console.ReadLine();

    if (input == "0 0")
    {
        return;
    }

    string[] splitInput = input.Split(' ');
    
    Console.WriteLine(int.Parse(splitInput[0]) + int.Parse(splitInput[1]));
}