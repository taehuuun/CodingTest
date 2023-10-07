int[] input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
string[] rows = new string[input[0]];

int cnt = 0;

for(int i = 0 ; i < rows.Length; i++)
{
    rows[i] = Console.ReadLine();
}

for (int i = 0; i < rows.Length; i++)
{
    if (rows[i].Contains('+'))
    {
        cnt++;
    }
}

Console.WriteLine(cnt);