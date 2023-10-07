string a = Console.ReadLine();
string b = Console.ReadLine();

string result = string.Empty;

for (long i = 0; i < a.Length; i++)
{
    result += a[(int)i] - '\0' > b[(int)i] - '\0' ? a[(int)i] :b[(int)i];
}

Console.WriteLine(result);