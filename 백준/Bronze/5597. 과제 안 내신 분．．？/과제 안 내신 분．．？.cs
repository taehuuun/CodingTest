int[] student = new int[30];

for (int i = 0; i < student.Length-2; i++)
{
    int input = int.Parse(Console.ReadLine());

    student[input - 1]++;
}

for (int i = 0; i < student.Length; i++)
{
    if (student[i] == 0)
    {
        Console.WriteLine(i+1);
    }
}