int caseCnt = int.Parse(Console.ReadLine());

for (int i = 0; i < caseCnt; i++)
{
    int inputCnt = int.Parse(Console.ReadLine());

    float sum = 0f;
    
    for (int j = 0; j < inputCnt; j++)
    {
        string[] input = Console.ReadLine().Split(' ');

        sum += float.Parse(input[1]) *  float.Parse(input[2]);
    }
    
    Console.WriteLine($"${sum:0.00}");
}