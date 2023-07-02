using System.Text;

int t = int.Parse(Console.ReadLine());

StringBuilder stringBuilder = new StringBuilder();

for (int i = 1; i <= t; i++)
{
    var numOfMultipleOfFive = 0;
    var n = int.Parse(Console.ReadLine());
    for (var j = 5; j <= n; j *= 5)
    {
        numOfMultipleOfFive += n / j;
    }

    stringBuilder.AppendLine(numOfMultipleOfFive.ToString());
}
Console.Write(stringBuilder.ToString());
