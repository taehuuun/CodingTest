// 정수형으로 입력을 받아 n에 대입
int n  = int.Parse(Console.ReadLine());

// n번 반복
for (int i = 1; i <= n; i++)
{
    // i만큼 *를 출력
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    
    // 줄 바꿈
    Console.WriteLine();
}