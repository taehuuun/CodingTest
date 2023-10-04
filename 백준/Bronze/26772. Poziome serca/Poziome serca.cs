using System.Text;

int n = int.Parse(Console.ReadLine());

StringBuilder sb = new StringBuilder();

string[] heart =
{
    " @@@   @@@  ",
    "@   @ @   @ ",
    "@    @    @ ",
    "@         @ ",
    " @       @  ",
    "  @     @   ",
    "   @   @    ",
    "    @ @     ",
    "     @      "
};

for (int i = 0; i < heart.Length; i++)
{
    for (int j = 0; j < n; j++)
    {
        sb.Append(heart[i]);
    }
    sb.Append('\n');
}

Console.WriteLine(sb);