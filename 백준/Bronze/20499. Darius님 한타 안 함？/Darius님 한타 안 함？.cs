int[] kda = Array.ConvertAll(Console.ReadLine().Split('/'),int.Parse);

Console.WriteLine((kda[0] + kda[2] < kda[1] || kda[1] == 0) ? "hasu" : "gosu");