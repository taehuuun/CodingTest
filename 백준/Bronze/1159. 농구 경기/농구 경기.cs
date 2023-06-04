int n = int.Parse(Console.ReadLine());
int[] count = new int[26];
string answer = "";

for (int i = 0; i < n; i++)
{
    string inputName = Console.ReadLine();

    count[inputName[0] - 'a']++;
}

for (int i = 0; i < count.Length; i++)
{
    if (count[i] >= 5)
    {
        answer += (char)('a' + i);
    }
}

Console.WriteLine(answer == "" ? "PREDAJA" : answer);