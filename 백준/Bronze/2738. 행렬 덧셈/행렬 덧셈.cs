string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int n = int.Parse(splitInput[0]);
int m = int.Parse(splitInput[1]);

int[,] matrix = new int[n,m];

for (int y = 0; y < n*2; y++)
{
    string inputRow = Console.ReadLine();
    string[] splitRows = inputRow.Split(' ');

    for (int x = 0; x < splitRows.Length; x++)
    {
        int ry = y < n ? y : y - n;

        matrix[ry, x] += int.Parse(splitRows[x]);
    }
}

for (int y = 0; y < n; y++)
{
    for (int x = 0; x < m; x++)
    {
        Console.Write($"{matrix[y,x]} ");
    }
    
    Console.WriteLine();
}