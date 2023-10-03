int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int width = input[0];
    int height = input[1];
    int times = input[2];

    int curWidth = width;
    int curHeight = height;
    
    for (int j = 0; j < times; j++)
    {
        if (curWidth > curHeight)
        {
            curWidth /= 2;
        }
        else
        {
            curHeight /= 2;
        }
        
        if(curWidth == 0 && curHeight ==0)
            break;
    }
    Console.WriteLine($"Data set: {width} {height} {times}");

    if (curWidth > curHeight)
    {
        Console.WriteLine($"{curWidth} {curHeight}");
    }
    else
    {
        Console.WriteLine($"{curHeight} {curWidth}");
    }
    
    if (i < n - 1)
    {
        Console.WriteLine();
    }
}