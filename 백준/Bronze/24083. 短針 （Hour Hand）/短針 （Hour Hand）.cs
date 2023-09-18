int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int result = (a + b) % 12 == 0 ? 12 : (a + b) % 12;

Console.WriteLine($"{result}");