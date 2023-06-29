int n = int.Parse(Console.ReadLine());

string result = "";

for (int i = 0; i < n; i++)
{
    if (i % 6 == 0 && i >0)
    {
        result += "Go! ";
    }

    result += $"{i + 1} ";
}

result += "Go!";

Console.WriteLine(result);