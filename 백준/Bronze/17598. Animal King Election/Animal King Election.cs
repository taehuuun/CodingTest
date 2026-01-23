var sr = new StreamReader(Console.OpenStandardInput());
var lion = 0;
var tiger = 0;
var input = string.Empty; 

for (int i = 0; i < 9; i++)
{
    input = sr.ReadLine();
    
    if (input == "Lion")
    {
        lion++;
    }
    else
    {
        tiger++;
    }
}

Console.WriteLine(lion > tiger ? "Lion" : "Tiger");