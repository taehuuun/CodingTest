using System.Net.WebSockets;

while (true)
{
    string input = Console.ReadLine();

    if (input == "0")
    {
        return;
    }
    
    float parseValue = float.Parse(input);

    float sum = 1f;
    float calWife = 1 * parseValue;
    float calSack = calWife * parseValue;
    float calCat = calSack * parseValue;
    float calLittleCat = calCat * parseValue;

    sum += calWife + calSack + calCat + calLittleCat;

    Console.WriteLine($"{sum:0.00}");
}
