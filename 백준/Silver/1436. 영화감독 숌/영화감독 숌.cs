int n = int.Parse(Console.ReadLine());

int targetNum = 0;
int count = 0;

while (n != count)
{
    targetNum++;
    if (targetNum.ToString().Contains("666"))
    {
        count++;
    }
}

Console.WriteLine(targetNum);