using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();

        for(int i = 0 ; i < s.Length; i++)
        {
            Console.Write($"{(char.IsLower(s[i]) ? char.ToUpper(s[i]) : char.ToLower(s[i]) )}");
        }
    }
}