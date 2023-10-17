int n = int.Parse(Console.ReadLine());

int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

int maxScore = nums.Max();
float totalScore = 0;

for (int i = 0; i < nums.Length; i++)
{
    totalScore += (float)nums[i] / maxScore * 100;
}

Console.WriteLine($"{(totalScore / n):0.0000}");