using System.Numerics;

while (true)
{
    BigInteger input = BigInteger.Parse(Console.ReadLine());

    if (input == 0)
    {
        break;
    }

    Console.WriteLine(input % 42 == 0 ? "PREMIADO" : "TENTE NOVAMENTE");
}