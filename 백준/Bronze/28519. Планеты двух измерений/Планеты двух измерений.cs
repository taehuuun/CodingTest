var nums = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

if (nums[0] > nums[1])
    (nums[0], nums[1]) = (nums[1], nums[0]);

Console.WriteLine(Math.Min(nums[0] + nums[1], nums[0] + nums[0] + 1));