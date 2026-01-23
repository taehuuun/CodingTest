var sr = new StreamReader(Console.OpenStandardInput());

// 4줄 입력: 각 바퀴에 걸린 시간(초)
int sum = 0;

sum += int.Parse(sr.ReadLine());
sum += int.Parse(sr.ReadLine());
sum += int.Parse(sr.ReadLine());
sum += int.Parse(sr.ReadLine());

// 5바퀴를 1800초 이하로 완주하면 통과
Console.WriteLine( sum + 300 <= 1800 ? "Yes" : "No");