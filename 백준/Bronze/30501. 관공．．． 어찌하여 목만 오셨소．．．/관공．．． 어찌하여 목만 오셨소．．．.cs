int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();

    if (input.Contains('S'))
    {
        Console.WriteLine(input);
        break;
    }
}