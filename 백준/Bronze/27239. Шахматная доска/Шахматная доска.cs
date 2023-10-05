int num = int.Parse(Console.ReadLine());

string result = string.Empty;
char alphabet = (char)(num % 8 + 96);
int number = (num-1) / 8 +1;

result = num % 8 == 0 ? $"h{number}" : $"{alphabet}{number}";
Console.WriteLine($"{result}");