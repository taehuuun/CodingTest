using System.Text;

int n = int.Parse(Console.ReadLine());

StringBuilder sb = new StringBuilder();

for (int i = 1; i <= n; i++)
{
    if (i % 7 == 0 && i % 11 == 0)
    {
        sb.AppendLine("Wiwat!");
    }
    else if (i % 7 == 0)
    {
        sb.AppendLine("Hurra!");
    }
    else if (i % 11 == 0)
    {
        sb.AppendLine("Super!");
    }
    else
    {
        sb.AppendLine(i.ToString());
    }
}

Console.Write(sb);