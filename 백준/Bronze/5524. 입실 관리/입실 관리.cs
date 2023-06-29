int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string result = string.Empty;
    
    for (int j = 0; j < input.Length; j++)
    {
        if (char.IsUpper(input[j]))
        {
            result += char.ToLower(input[j]);
        }
        else
        {
            result += input[j];
        }
    }
    
    Console.WriteLine(result);
}