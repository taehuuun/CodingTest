char[] vowel = {'a','e','i','o','u'};

while (true)
{
    string input = Console.ReadLine();

    if (input == "end")
    {
        return;
    }

    if (IsContainVowel(input) && !IsContinueVowelOrConsonant(input) && !IsSameContinueCount(input))
    {
        Console.WriteLine($"<{input}> is acceptable.");
    }
    else
    {
        Console.WriteLine($"<{input}> is not acceptable.");
    }
}

bool IsContainVowel(string str)
{
    for (int i = 0; i < vowel.Length; i++)
    {
        if (str.Contains(vowel[i]))
        {
            return true;
        }
    }

    return false;
}

bool IsContinueVowelOrConsonant(string str)
{
    if (str.Length < 3)
    {
        return false;
    }
    
    int continueVowel = 0;
    int continueConstant = 0;

    for (int i = 0; i < str.Length; i++)
    {
        if (vowel.Contains(str[i]))
        {
            continueVowel++;
            continueConstant = 0;
        }
        else
        {
            continueConstant++;
            continueVowel = 0;
        }

        if (continueVowel >= 3 || continueConstant >= 3)
        {
            return true;
        }
    }

    return false;
}

bool IsSameContinueCount(string str)
{
    if (str.Length < 2)
    {
        return false;
    }
    
    char lastChar = str[0];

    for (int i = 1; i < str.Length; i++)
    {
        if((lastChar == 'e' && str[i] == lastChar) || (lastChar == 'o' && str[i] == lastChar))
            continue;

        if (lastChar == str[i])
            return true;

        lastChar = str[i];
    }

    return false;
}