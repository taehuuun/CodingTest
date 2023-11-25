int[] nums = new int[10];

int total = 0;

for (int i = 0; i < nums.Length; i++)
{
    int input = int.Parse(Console.ReadLine());
    nums[i] = input;
    total += input;
}

for(int i = 0 ; i < nums.Length; i++)
{
    if (nums[i] == total - nums[i])
    {
        Console.WriteLine(nums[i]);
        break;
    }
}