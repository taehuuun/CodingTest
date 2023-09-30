// T / 1 ~ 100
// a,b,c / 1 ~ 60
// 최대 연산 횟수 : 100 * 60 ^ 3 = 21,600,000회
int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    int[] abc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int count = 0;
    
    for (int a = 1; a <= abc[0]; a++)
    {
        for (int b = 1; b <= abc[1]; b++)
        {
            for (int c = 1; c <= abc[2]; c++)
            {
                if (a % b == b % c && b % c == c % a)
                {
                    count++;
                }
            }
        }
    }
    
    Console.WriteLine(count);
}