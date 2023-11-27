int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int x = input[0];
int y = input[1];
int w = input[2];
int h = input[3];

int[] dist = new int[4];

// 왼쪽 경게선 => x의 값과 같음
dist[0] = x;
// 오른쪽 경계선 => w - x의 값과 같음
dist[1] = w - x;
// 위쪽 경계선 => h - y의 값과 같음
dist[2] = h - y;
// 아래쪽 경계선 => y의 값과 같음
dist[3] = y;

Console.WriteLine(dist.Min());