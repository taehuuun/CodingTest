Console.ReadLine();

int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int evenCnt = 0;
int oddCnt = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] % 2 == 0)
    {
        evenCnt++;
    }
    else
    {
        oddCnt++;
    }
}

if (evenCnt > oddCnt)
{
    Console.WriteLine("Happy");
}
else
{
    Console.WriteLine("Sad");
}