int[] input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

Array.Sort(input);

Console.WriteLine(input[1]);