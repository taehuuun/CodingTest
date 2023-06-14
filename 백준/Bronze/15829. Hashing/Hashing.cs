int len = int.Parse(Console.ReadLine());

string str = Console.ReadLine();
int result = 0;

for (int i = 0; i < str.Length; i++)
{
    result += ((str[i] - 'a' + 1) * (int)MathF.Pow(31, i)) % 1234567891;
}

Console.WriteLine(result);