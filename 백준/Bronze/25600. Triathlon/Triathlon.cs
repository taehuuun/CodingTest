int n = int.Parse(Console.ReadLine());

int maxScore = int.MinValue;

for (int i = 0; i < n; i++)
{
    int[] scores = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int a = scores[0];
    int d = scores[1];
    int g = scores[2];

    int score = a == (d + g) ? (a * (d + g)) * 2 : a * (d + g);
    
    maxScore = Math.Max(maxScore, score);
}

Console.WriteLine(maxScore);