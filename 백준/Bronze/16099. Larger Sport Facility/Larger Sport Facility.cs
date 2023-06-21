using System.Numerics;

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string[] splitInput = input.Split(' ');

    BigInteger t1 = BigInteger.Parse(splitInput[0]);
    BigInteger t2 = BigInteger.Parse(splitInput[1]);
    BigInteger e1 = BigInteger.Parse(splitInput[2]);
    BigInteger e2 = BigInteger.Parse(splitInput[3]);

    if (t1 * t2 > e1 * e2)
    {
        Console.WriteLine("TelecomParisTech");
    }
    else if (t1 * t2 < e1 * e2)
    {
        Console.WriteLine("Eurecom");
    }
    else
    {
        Console.WriteLine("Tie");
    }
}