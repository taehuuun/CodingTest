using System.Text;

int n = int.Parse(Console.ReadLine());

StringBuilder stringBuilder = new StringBuilder();

for (int i = n; i > 0; i--)
{
    stringBuilder.Append($"{i}\n");
}

Console.WriteLine(stringBuilder.ToString());