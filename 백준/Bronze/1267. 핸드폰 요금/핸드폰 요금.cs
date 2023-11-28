Console.ReadLine();

int[] useTime = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int yBill = 0;
int mBill = 0;

for (int i = 0; i < useTime.Length; i++)
{
    yBill += (useTime[i] / 30+1) * 10;
    mBill += (useTime[i] / 60+1) * 15;
}

if (yBill > mBill)
{
    Console.WriteLine($"M {mBill}");
}
else if (yBill == mBill)
{
    Console.WriteLine($"Y M {mBill}");
}
else
{
    Console.WriteLine($"Y {yBill}");
}