string[] nums = Console.ReadLine().Split();

int oneCnt = 0;
int twoCnt = 0;

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] == "1")
    {
        oneCnt++;
    }
    else
    {
        twoCnt++;
    }
}

Console.WriteLine(oneCnt > twoCnt ? "1" : "2");