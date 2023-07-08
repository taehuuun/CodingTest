double[] nums = Array.ConvertAll(Console.ReadLine().Split(),double.Parse);

int case1 = (int)(nums[0] * nums[1] / nums[2]);
int case2 = (int)(nums[0] / nums[1] * nums[2]);

Console.WriteLine(Math.Max(case1,case2));