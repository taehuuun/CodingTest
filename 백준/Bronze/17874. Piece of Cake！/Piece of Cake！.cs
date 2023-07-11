int[] input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

int w = Math.Max(input[2], input[0] - input[2]);
int d = Math.Max(input[1], input[0] - input[1]);

Console.WriteLine(w*d*4);