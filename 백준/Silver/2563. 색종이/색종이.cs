int[,] map = new int[101,101];

int n = int.Parse(Console.ReadLine());
int area = 0;

for (int i = 0; i < n; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    
    FillMap(input[0],input[1]);
}

Console.WriteLine(area);

void FillMap(int startX, int startY)
{
    for (int y = startY; y < startY+10; y++)
    {
        for (int x = startX; x < startX+10; x++)
        {
            if (map[y, x] == 0)
            {
                map[y, x] = 1;
                area++;
            }
        }

    }
}