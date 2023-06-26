int n = int.Parse(Console.ReadLine());

string result = "";

for (int i = 0; i < n / 4; i++)
{
    result += "long ";
}

result += "int";

Console.WriteLine(result);