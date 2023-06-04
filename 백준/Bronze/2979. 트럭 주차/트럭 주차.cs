internal class Program
{
    public static void Main(string[] args)
    {
        int[] bills = new int[3];
        int sum = 0;

        string inputBills = Console.ReadLine();
        string[] splitBills = inputBills.Split(' ');

        for (int i = 0; i < splitBills.Length; i++)
        {
            bills[i] = int.Parse(splitBills[i]);
        }

        int[] time = new int[101];

        for (int i = 0; i < 3; i++)
        {
            string input = Console.ReadLine();
            string[] nums = input.Split(' ');

            int start = int.Parse(nums[0]);
            int end = int.Parse(nums[1]);

            for (int j = start; j < end; j++)
            {
                time[j]++;
            }
        }

        for (int i = 0; i < time.Length; i++)
        {
            if (time[i] == 0)
                continue;
    
            switch (time[i])
            {
                case 1:
                    sum += bills[0];
                    break;
                case 2:
                    sum += bills[1] * 2;
                    break;
                case 3:
                    sum += bills[2] * 3;
                    break;
            }
        }

        Console.WriteLine(sum);
    }
}