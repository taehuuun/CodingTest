int[] hlab = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

var h = hlab[0];
var l = hlab[1];
var a = hlab[2];
var b = hlab[3];

if((a <= l && b <= h * 2) || (b <= l && a <= h * 2))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}