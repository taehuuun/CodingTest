int[] inputNums = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

int n = inputNums[0];
int m = inputNums[1];
int k = inputNums[2];

int jumpCnt = 0;
int current = 0;

while (current < n)
{
    n += m;
    current += k;
    jumpCnt++;
}

Console.WriteLine(jumpCnt);