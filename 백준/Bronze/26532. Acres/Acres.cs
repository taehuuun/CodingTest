float[] input = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);

float field = input[0] * input[1];
float acres = field / 4840;

int seeds = (int)Math.Ceiling(acres / 5);

Console.WriteLine(seeds);