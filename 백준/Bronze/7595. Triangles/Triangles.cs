using System.Text;

while (true)
{
    int n = int.Parse(Console.ReadLine());

    if (n == 0)
    {
        return;
    }

    for (int i = 0; i < n; i++)
    {
        StringBuilder stringBuilder = new StringBuilder();
        for (int j = 0; j <= i; j++)
        {
            stringBuilder.Append("*");
        }
        Console.WriteLine(stringBuilder.ToString());
    }
}