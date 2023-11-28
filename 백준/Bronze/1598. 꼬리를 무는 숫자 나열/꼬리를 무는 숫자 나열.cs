int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

input[0]--;
input[1]--;

Point a = new Point(input[0]);
Point b = new Point(input[1]);

Console.WriteLine(Math.Abs(b.x - a.x) + Math.Abs(b.y - a.y));

class Point
{
    public int x;
    public int y;

    public Point(int num)
    {
        x = num / 4;
        y = num % 4;
    }
}