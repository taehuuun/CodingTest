string inputStr = Console.ReadLine();

int[] count = new int[26];
int oddCount = 0;
string mid = "";
string prefix = "";

for (int i = 0; i < inputStr.Length; i++)
{
    count[inputStr[i] - 'A']++;
}

for (int i = 0; i < 26; i++)
{
    if (count[i] % 2 != 0)
    {
        mid += (char)(i+'A');
        oddCount++;
    }

    prefix += new string((char)(i+'A'), count[i] / 2);
}

if (oddCount > 1)
{
    Console.WriteLine("I'm Sorry Hansoo");
}
else
{
    string suffix = new string(prefix.Reverse().ToArray());
    Console.WriteLine(prefix + mid + suffix);
}
