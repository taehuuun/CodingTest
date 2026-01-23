var sr = new StreamReader(Console.OpenStandardInput());
int n = int.Parse(sr.ReadLine());
string str = sr.ReadLine();

for (int i = 0; i < n-1; i++)
{
    if (str[i + 1] == 'J')
    {
        Console.WriteLine(str[i]);
    }
}
