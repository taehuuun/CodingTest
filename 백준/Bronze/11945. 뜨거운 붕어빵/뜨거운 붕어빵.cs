string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int y = int.Parse(splitInput[0]);

string[] rows = new string[y];

for (int i = 0; i < y; i++)
{
    rows[i] = Console.ReadLine();
}

for (int i = 0; i < y; i++)
{
    for (int j = rows[i].Length - 1; j >= 0; j--)
    {
        Console.Write(rows[i][j]);
    }
    Console.WriteLine();
}