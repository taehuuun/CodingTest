// 4줄 입력: 각 바퀴에 걸린 시간(초)
int sum = 0;

for (int i = 0; i < 4; i++)
{
    // 공백/개행이 섞여 들어올 가능성까지 고려하여 Trim 처리
    string line = Console.ReadLine()!;
    int t = int.Parse(line.Trim());

    // 4바퀴 시간 누적
    sum += t;
}

// 마지막 1바퀴는 정확히 300초
int total = sum + 300;

// 5바퀴를 1800초 이하로 완주하면 통과
if (total <= 1800)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}