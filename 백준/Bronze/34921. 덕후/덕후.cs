int[] at = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

var p = 10 + 2 * (25 - at[0] + at[1]);

Console.WriteLine(p >= 0? p : 0);