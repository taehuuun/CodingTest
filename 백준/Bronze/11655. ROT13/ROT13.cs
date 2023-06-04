string input = Console.ReadLine();
string encrypt = "";

for (int i = 0; i < input.Length; i++)
{
    if (char.IsLower(input[i]))
    {
        int rot13 = (input[i] + 13);

        encrypt += rot13 <= 'z' ? (char)rot13 : (char)('a'+ rot13-'z'-1);
    }
    else if (char.IsUpper(input[i]))
    {
        int rot13 = (input[i] + 13);

        encrypt += rot13 <= 'Z' ? (char)rot13 : (char)('A' + rot13-'Z'-1);
    }
    else
    {
        encrypt += input[i];
    }
}

Console.WriteLine(encrypt);