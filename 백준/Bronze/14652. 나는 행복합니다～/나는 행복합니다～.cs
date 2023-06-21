string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int n = int.Parse(splitInput[0]);
int m = int.Parse(splitInput[1]);
int k = int.Parse(splitInput[2]);

int idx = 0;
for (int y = 0; y < n; y++)
{
    for (int x = 0; x < m; x++)
    {
        if (idx == k)
        {
            Console.WriteLine($"{y} {x}");
        }
        idx++;
    }
}