int l = int.Parse(Console.ReadLine());
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());

int finishMathDay = (b % d == 0) ? b/d : b/d + 1;
int finishKoreanDay = (a % c == 0) ? a/c : a/c + 1;

Console.WriteLine(l - Math.Max(finishKoreanDay, finishMathDay));