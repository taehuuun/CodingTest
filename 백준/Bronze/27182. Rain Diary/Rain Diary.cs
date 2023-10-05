int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int result = input[0] >= 8 ? input[0] - 7: input[1] + 7;   

Console.WriteLine(result);