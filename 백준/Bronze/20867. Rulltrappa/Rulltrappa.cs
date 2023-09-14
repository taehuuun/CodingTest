int[] MSG = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
float[] AB = Array.ConvertAll(Console.ReadLine().Split(' '),float.Parse);
int[] LR = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int M = MSG[0];     // 총 계단 수
int S = MSG[1];     // 가만히 있을 때 1초당 올라가는 계단 수
int G = MSG[2];     // 걸어 올라 갈 때 1초당 올라가는 계단 수
float A = AB[0];    // 왼쪽 줄 (걸어 올라 가는) A명이 1초마다 에스컬레이터를 걸어 올라 감 => 다음 사람이 타기 까지 1/A초를 기다려야 함
float B = AB[1];    // 오른쪽 줄 (가만히 있는) B명이 1초마다 에스컬레이터를 올라 감 => 다음 사람이 타기 까지 1/B초를 기다려야 함
int L = LR[0];      // 왼쪽 줄 (걸어 올라 가는) 에는 L명이 서 있음
int R = LR[1];      // 오른쪽 줄 (가만히 있는) 에는 R 명이 서 있음

// 초당 올라가는 계단 수로 따졌을 때 걸리는 시간
float climbStairsPerSecondL = (float)(M) / G;
float climbStairsPerSecondR = (float)(M) / S;

// 에스컬레이터에 오르기 위해 기다리는 시간
float waitTimeL = 1 / A * L;
float waitTimeR = 1 / B * R;

// 총 걸리는 시간
float totalL = climbStairsPerSecondL + waitTimeL;
float totalR = climbStairsPerSecondR + waitTimeR;

Console.WriteLine(totalR < totalL ? "latmask" : "friskus");