// 오늘의 온도 : t1, 오늘의 풍속 : v1
// 내일의 온도 : t2, 오늘의 풍속 : v2

// 폭풍이 예상되면 경고 메시지 발송
// 내일 기온(t2)이 영하이고, 풍속(v2)가 초속 10cm 이상일 때
// A storm warning for tomorrow! Be careful and stay home if possible!

// 그렇지 않을 경우, 좋지 않은 기상 변화만 메시지 발송
// 1. 만약 내일의 기온이 오늘보다 낮아 진다면(t1 > t2), 한파 경고
// MCHS warns! Low temperature is expected tomorrow.
// 2. 만약 기온이 떨어지지 않고 (t1==t2), 풍속이 오늘 보다 빨라진다면 (v2>v1) 강풍 경고
// MCHS warns! Strong wind is expected tomorrow.
// 3. 위 두 조건에 해당 하지 않다면
// No message

int[] today = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] tomorrow = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int t1 = today[0];
int v1 = today[1];
int t2 = tomorrow[0];
int v2 = tomorrow[1];

if (t2 < 0 && v2 >= 10)
{
    Console.WriteLine("A storm warning for tomorrow! Be careful and stay home if possible!");
}
else if (t2 < t1)
{
    Console.WriteLine("MCHS warns! Low temperature is expected tomorrow.");
}
else if (v2 > v1)
{
    Console.WriteLine("MCHS warns! Strong wind is expected tomorrow.");
}
else
{
    Console.WriteLine("No message");
}