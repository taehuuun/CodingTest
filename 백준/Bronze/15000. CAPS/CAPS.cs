using System.Text;

string input = Console.ReadLine();

StringBuilder stringBuilder = new StringBuilder();

for (int i = 0; i < input.Length; i++)
{
    stringBuilder.Append(char.ToUpper(input[i]));
}

Console.WriteLine(stringBuilder.ToString());