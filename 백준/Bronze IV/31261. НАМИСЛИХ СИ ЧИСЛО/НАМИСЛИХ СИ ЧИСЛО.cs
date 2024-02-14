// a * (a * (a + b) + a) = x

int[] inputNums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int a = inputNums[0];
int b = inputNums[1];

Console.WriteLine(a * (a * (a + b) + a));