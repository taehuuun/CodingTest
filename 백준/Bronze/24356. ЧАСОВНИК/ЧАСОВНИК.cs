int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int t1 = input[0];
int m1 = input[1];
int t2 = input[2];
int m2 = input[3];

m1 += t1 * 60;
m2 += t2 * 60;

if (m1 > m2)
{
    m2 += 24 * 60;
}

var totalMin = m2 - m1;
var count = totalMin/30;

Console.WriteLine(totalMin);
Console.WriteLine(count);