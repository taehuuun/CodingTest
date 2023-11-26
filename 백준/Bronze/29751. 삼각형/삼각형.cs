int[] wh = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

Console.WriteLine((wh[0] * wh[1] * 0.5f).ToString("F1"));