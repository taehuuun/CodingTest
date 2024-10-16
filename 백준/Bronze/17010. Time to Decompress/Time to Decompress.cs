int repeat = int.Parse(Console.ReadLine());

for (int i = 0; i < repeat; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    
    int count = int.Parse(input[0]);
    string character = input[1];

    for (int j = 0; j < count; j++)
    {
        Console.Write(character);
    }
    
    Console.WriteLine();
}