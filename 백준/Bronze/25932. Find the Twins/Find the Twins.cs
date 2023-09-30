using System.Xml;

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    bool zack = false;
    bool mack = false;
    int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    for (int j = 0; j < numbers.Length; j++)
    {
        if (numbers[j] == 17)
            zack = true;
        else if (numbers[j] == 18)
            mack = true;
    }
    
    Console.WriteLine(string.Join(' ', numbers));
    
    if (zack && mack)
    {
        Console.WriteLine("both");
    }
    else if (zack)
    {
        Console.WriteLine("zack");
    }
    else if (mack)
    {
        Console.WriteLine("mack");
    }
    else
    {
        Console.WriteLine("none");
    }
    
    if( i < n-1)
        Console.WriteLine();
}