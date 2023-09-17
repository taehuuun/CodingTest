sbyte[] input = Array.ConvertAll(Console.ReadLine().Split(),sbyte.Parse);

Console.WriteLine(Math.Max(input[0]+input[1], input[0]-input[1]));
Console.WriteLine(Math.Min(input[0]+input[1], input[0]-input[1]));