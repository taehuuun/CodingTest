int n = int.Parse(Console.ReadLine());
char[,] map = new char[n,n];

for (int y = 0; y < n; y++)
{
    string inputRow = Console.ReadLine();

    for (int x = 0; x < inputRow.Length; x++)
    {
        map[y, x] = inputRow[x];
    }
}

Console.WriteLine(QuadTree(0,0,n));

string QuadTree(int x, int y, int size)
{
    if (size == 1) return new string(map[y,x],1);

    char c = map[y, x];
    string retStr = "";

    int nextSize = size / 2;
    for (int ny = y; ny < y + size; ny++)
    {
        for (int nx = x; nx < x + size; nx++)
        {
            if (c != map[ny, nx])
            {
;               retStr += '(';
                retStr += QuadTree(x, y, nextSize);
                retStr += QuadTree(x + nextSize, y, nextSize);
                retStr += QuadTree(x, y + nextSize, nextSize);
                retStr += QuadTree(x + nextSize, y + nextSize, nextSize);
                retStr += ')';
                return retStr;
            }
        }
    }
    
    return new string(map[y,x],1); 
}