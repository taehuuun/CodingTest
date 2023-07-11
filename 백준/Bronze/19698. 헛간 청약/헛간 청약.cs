int[] nums = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

int canMoveIn = (nums[1] / nums[3]) * (nums[2] / nums[3]);

Console.WriteLine(Math.Min(nums[0],canMoveIn));