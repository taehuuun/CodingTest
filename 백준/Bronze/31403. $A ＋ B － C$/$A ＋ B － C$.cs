int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int numSum = a + b - c;
int charSum = int.Parse($"{a.ToString()}{b.ToString()}") - c;

Console.WriteLine(numSum);
Console.WriteLine(charSum);