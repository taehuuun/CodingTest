string input = Console.ReadLine();

string[] splitInput = input.Split('"');

if (splitInput.Length < 3)
{
    Console.WriteLine("CE");
    return;
}

if (!string.IsNullOrEmpty(splitInput[0]) ||string.IsNullOrEmpty(splitInput[1])|| !string.IsNullOrEmpty(splitInput[2]))
{
    Console.WriteLine("CE");
    return;
}

Console.WriteLine(splitInput[1]);