int sum = 0;
for (int i = 0; i < 5; i++)
{
    int score = int.Parse(Console.ReadLine());

    sum += score >= 40 ? score : 40;
}

Console.WriteLine(sum/5);