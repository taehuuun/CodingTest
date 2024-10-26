int n = int.Parse(Console.ReadLine());
string str1 = Console.ReadLine();
string str2 = Console.ReadLine();

int count = 0;

for (int i = 0; i < n; i++)
{
    if (str1[i] != str2[i])
    {
        count++;
    }
}

Console.WriteLine(count);