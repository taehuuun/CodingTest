// 입력 값을 정수형으로 파싱하여 n에 대입
int n = int.Parse(Console.ReadLine());

// 1부터 9까지 반복
for (int i = 1; i <= 9; i++)
{
    // 문자열 보간을 이용해 구구단을 출력
    Console.WriteLine($"{n} * {i} = {n*i}");
}