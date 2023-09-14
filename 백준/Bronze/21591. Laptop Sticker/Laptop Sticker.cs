int[] input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

bool isValid = input[0] - 2 >= input[2] && input[1] - 2 >= input[3];

Console.WriteLine(isValid ? "1" : "0");