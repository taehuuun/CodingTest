int[] money = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

if (money[0] + money[2] > money[1])
{
    Console.WriteLine(money[0] + money[2]);
}
else
{
    Console.WriteLine(money[1]);
}