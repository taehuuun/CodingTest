int t = int.Parse(Console.ReadLine());

for (int T = 0; T < t; T++)
{
    int n = int.Parse(Console.ReadLine());

    for (int N = 0; N < n; N++)
    {
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        
        Console.WriteLine($"{nums[0] + nums[1]} {nums[0] * nums[1]}");
    }
}