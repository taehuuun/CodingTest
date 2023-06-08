int n = int.Parse(Console.ReadLine());

List<string> numList = new List<string>();

for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine();
    string parseNum = "";
    
    for (int j = 0; j < str.Length; j++)
    {
        if (char.IsDigit(str[j]))
        {
            parseNum += str[j];
        }
        else
        {
            if (parseNum != "")
            {
                if (parseNum.StartsWith("0"))
                {
                    parseNum = StartZero(parseNum);
                }

                numList.Add(parseNum);
                parseNum = "";
            }
        }
    }

    if (!string.IsNullOrEmpty(parseNum))
    {
        if (parseNum.StartsWith("0"))
        {
            parseNum = StartZero(parseNum);
        }
        
        numList.Add(parseNum);
    }
}

numList.Sort((a, b) => 
{
    if (a.Length == b.Length)
        return string.Compare(a, b);
    else
        return a.Length - b.Length;
});

for (int i = 0; i < numList.Count; i++)
{
    Console.WriteLine(numList[i]);
}

string StartZero(string str)
{
    if (str.Length == 1)
    {
        return "0";
    }

    int subIdx = -1;
        
    for (int k = 0; k < str.Length; k++)
    {
        if (str[k] != '0')
        {
            subIdx = k;
            break;
        }
    }

    if (subIdx == -1)
    {
        return "0";
    }
                        
    str =str.Substring(subIdx, str.Length-subIdx);
    
    if (string.IsNullOrEmpty(str))
    {
        str = "0";
    }

    return str;
}