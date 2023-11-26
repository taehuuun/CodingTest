int[] hw = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

char[,] map = new Char[hw[0],hw[1]];

int zeroCnt = 0;
int oneCnt = 0;

for (int i = 0; i < map.GetLength(0); i++)
{
    string row = Console.ReadLine();

    for (int j = 0; j < row.Length; j++)
    {
        if (row[j] == '0')
        {
            zeroCnt++;
        }
        else
        {
            oneCnt++;
        }
    }
}

Console.WriteLine(Math.Min(zeroCnt,oneCnt));