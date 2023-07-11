int s = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());

int happy = s + 2 *m + 3*l;

Console.WriteLine(happy >= 10? "happy":"sad");