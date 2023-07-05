int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string[] splitInput = input.Split(' ');

    int inputX = int.Parse(splitInput[0]);
    int inputY = int.Parse(splitInput[1]);

    for (int y = 0; y < inputY; y++)
    {
        for (int x = 0; x < inputX; x++)
        {
            Console.Write("X");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}