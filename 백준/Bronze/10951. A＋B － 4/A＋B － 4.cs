while (true)
{
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        return;
    }

    string[] splitInput = input.Split(' ');

    int a = int.Parse(splitInput[0]);
    int b = int.Parse(splitInput[1]);
    
    Console.WriteLine(a+b);
}