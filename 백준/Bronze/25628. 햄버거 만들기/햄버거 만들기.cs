int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int bread = input[0] /2;
int pattie = input[1];

Console.WriteLine(Math.Min(bread, pattie));