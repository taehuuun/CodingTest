int[] nums = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

if (nums[1] <= nums[0] && nums[0] <= nums[2])
{
    Console.WriteLine(nums[0]);
}
else
{
    int absL = Math.Abs(nums[0] - nums[1]);
    int absR = Math.Abs(nums[0] - nums[2]);

    Console.WriteLine(absL < absR ? nums[1] : nums[2]);
}