int caseCnt = int.Parse(Console.ReadLine());

for (int i = 0; i < caseCnt; i++)
{
    Dictionary<string, int> wearType = new Dictionary<string, int>();
    
    int n = int.Parse(Console.ReadLine());

    long result = 1;

    for (int j = 0; j < n; j++)
    {
        string inputWear = Console.ReadLine();
        string[] splitWear = inputWear.Split(' ');

        if (!wearType.ContainsKey(splitWear[1]))
        {
            wearType.Add(splitWear[1],1);
        }
        else
        {
            wearType[splitWear[1]]++;
        }
    }

    foreach (var key in wearType.Keys)
    {
        result *= wearType[key] + 1;
    }

    result--;
    
    Console.WriteLine(result);
}