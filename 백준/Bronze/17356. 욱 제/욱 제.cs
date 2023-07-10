int[] inputData = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

double m = (double)(inputData[1] - inputData[0]) / 400;
double win = 1 / (1 + Math.Pow(10, m));

Console.WriteLine(win);