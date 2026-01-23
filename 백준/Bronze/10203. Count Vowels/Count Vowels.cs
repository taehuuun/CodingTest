var sr = new StreamReader(Console.OpenStandardInput());
var n = int.Parse(sr.ReadLine());

var str = string.Empty;
var count = 0;

for (int i = 0; i < n; i++)
{
    str = sr.ReadLine();
    count = 0;
    
    for (int j = 0; j < str.Length; j++)
    {
        if (str[j] == 'a' || str[j] == 'e' || str[j] == 'i' || str[j] == 'o' || str[j] == 'u')
        {
            count++;
        }
    }
    
    Console.WriteLine($"The number of vowels in {str} is {count}.");
}