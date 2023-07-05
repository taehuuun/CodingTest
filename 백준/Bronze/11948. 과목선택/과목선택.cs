List<int> abcd = new List<int>();
List<int> ef = new List<int>();

int sum = 0;

for (int i = 0; i < 4; i++)
{
    abcd.Add(int.Parse(Console.ReadLine()));
}

for (int i = 0; i < 2; i++)
{
    ef.Add(int.Parse(Console.ReadLine()));
}

abcd.Sort();
ef.Sort();

for (int i = abcd.Count-1; i > 0; i--)
{
    sum += abcd[i];
}

for (int i = ef.Count-1; i > 0; i--)
{
    sum += ef[i];
}

Console.WriteLine(sum);