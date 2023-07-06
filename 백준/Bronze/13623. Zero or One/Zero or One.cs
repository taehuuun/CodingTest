string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int sum = 0;

for (int i = 0; i < splitInput.Length; i++)
{
    sum += int.Parse(splitInput[i]);
}

if (sum == 0 || sum == 3)
{
    Console.WriteLine("*");
}
else if (sum == 2)
{
    string result = "";
    for (int i = 0; i < splitInput.Length; i++)
    {
        if (splitInput[i] == "0")
        {
            result += (char)('A' + i);
            break;
        }
    }
    
    Console.WriteLine(result);
}
else
{
    string result = "";
    for (int i = 0; i < splitInput.Length; i++)
    {
        if (splitInput[i] == "1")
        {
            result += (char)('A' + i);
            break;
        }
    }
    
    Console.WriteLine(result);
}
