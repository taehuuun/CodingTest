int[] hiarc = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int first = hiarc[0] * hiarc[1];
int second = hiarc[2] * hiarc[3] * hiarc[4];

Console.WriteLine(first - second);