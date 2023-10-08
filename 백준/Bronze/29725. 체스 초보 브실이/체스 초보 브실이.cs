char[,] board = new char[8,8];

Dictionary<char, int> article = new Dictionary<char, int>
{
    {'K',0},
    {'k',0},
    {'P',1},
    {'p',1},
    {'N',3},
    {'n',3},
    {'B',3},
    {'b',3},
    {'R',5},
    {'r',5},
    {'Q',9},
    {'q',9},
};


int bScore = 0;
int wScore = 0;

for (int i = 0; i < board.GetLength(0); i++)
{
    string row = Console.ReadLine();

    for (int j = 0; j < row.Length; j++)
    {
        board[i, j] = row[j];
    }
}

for (int y = 0; y < board.GetLength(0); y++)
{
    for (int x = 0; x < board.GetLength(1); x++)
    {
        if(board[y,x] == '.')
            continue;

        int addScore =article[board[y, x]]; 
        
        if (char.IsUpper(board[y, x]))
        {
            wScore += addScore;
        }
        else
        {
            bScore += addScore;
        }
    }
}

Console.WriteLine(wScore - bScore);