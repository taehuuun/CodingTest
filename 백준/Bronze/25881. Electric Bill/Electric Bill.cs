int[] bills = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int bill = int.Parse(Console.ReadLine());

    if (bill <= 1000)
    {
        Console.WriteLine($"{bill} {bill * bills[0]}");
    }
    else
    {
        int totalBill = 1000 * bills[0] + ((bill - 1000) * bills[1]);

        Console.WriteLine($"{bill} {totalBill}");
    }
}