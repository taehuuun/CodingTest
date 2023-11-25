DateTime inputDate = DateTime.Parse(Console.ReadLine());
DateTime criteriaDate = new DateTime(2023, 10, 21).AddDays(-35);

TimeSpan difDate = inputDate - criteriaDate;

if (difDate.TotalDays <= 0)
{
    Console.WriteLine("GOOD");
}
else
{
    Console.WriteLine("TOO LATE");
}

