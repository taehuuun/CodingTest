string inputStr = Console.ReadLine();

int[] count = new int[26];
int oddCount = 0;
string mid = "";
string answer = "";

for (int i = 0; i < inputStr.Length; i++)
{
    count[inputStr[i] - 'A']++;
}

for (int i = count.Length-1; i >=0 ; i--)
{
    if (count[i] > 0)
    {
        if (count[i] % 2 != 0)
        {
            mid += (char)(i+'A');
            count[i]--;
            oddCount++;
        }
        if (oddCount >= 2)
        {
            Console.WriteLine("I'm Sorry Hansoo");
            return;
        }


        for (int j = 0; j < count[i]; j+=2)
        {
            answer = (char)(i + 'A') + answer;
            answer += (char)(i + 'A');
        }
    }
}

if (answer == "" && mid != "")
{
    Console.WriteLine(mid);
    return;
}

if (mid != "")
{
    int idx = answer.Length / 2;
    string origin = answer;
    answer = "";

    for (int i = 0; i < origin.Length; i++)
    {
        answer += i == idx-1 ? origin[i] + mid : origin[i];
    }
}

Console.WriteLine(answer);