using System.Numerics;

BigInteger appleCnt = BigInteger.Parse(Console.ReadLine()); 
BigInteger diff = BigInteger.Parse(Console.ReadLine());

BigInteger klaudia = 0;
BigInteger natalia = 0;

if(appleCnt.IsEven)
{
    klaudia = appleCnt / 2 + diff/2;
    natalia = appleCnt / 2 - diff/2;
}
else
{
    klaudia = (appleCnt / 2 + 1) + diff / 2;
    natalia = appleCnt / 2 - diff/2;
}

Console.WriteLine(klaudia);
Console.WriteLine(natalia);
