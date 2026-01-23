var sr = new StreamReader(Console.OpenStandardInput());
var t = int.Parse(sr.ReadLine());

var n = 0;
var num = new int[] {};

for (int i = 0; i < t; i++)
{
    n = int.Parse(sr.ReadLine());
    num = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
    Console.WriteLine(num.Sum());
}