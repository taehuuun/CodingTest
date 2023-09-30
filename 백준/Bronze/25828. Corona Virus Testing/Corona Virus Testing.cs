int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int personalCnt = input[0] * input[1];
int groupCnt = input[1]  * input[2] + input[0];

if (personalCnt < groupCnt)
{
    Console.WriteLine("1");
}else if (personalCnt == groupCnt)
{
    Console.WriteLine("0");
}
else
{
    Console.WriteLine("2");
}