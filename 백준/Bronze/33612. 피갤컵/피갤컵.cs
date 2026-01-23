var sr = new StreamReader(Console.OpenStandardInput());
int n = int.Parse(sr.ReadLine());
int year = 2024;
int month = 8;
int addMonth = 7 * (n - 1);

if (addMonth > 0)
{
    month += addMonth;
    year += month / 12;
    month %= 12;
}

year = month == 0 ? year - 1 : year;
month = month == 0 ? 12 : month;

Console.WriteLine($"{year} {month }");