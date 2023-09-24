int[] abc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int avg = (abc[0] + abc[1] + abc[2]) / 3;
int distance = 0;

distance += abc[2] - avg;
abc[1] += abc[2] - avg;

distance += abc[1] - avg;

Console.WriteLine(distance);