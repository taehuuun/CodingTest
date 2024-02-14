int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Array.Sort(nums);

int total = nums.Sum() + 1;
total -= nums[0];

Console.WriteLine(total);