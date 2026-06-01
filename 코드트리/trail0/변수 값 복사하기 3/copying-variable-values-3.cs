using System;

public class Codetree
{  
    public static void Main()
    {
        int a = 1;
        int b = 5;
        int c = 3;

        a = c;
        a = a+c;
        b = b-c;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}
