int angle = 0;

for (int i = 0; i < 10; i++)
{
    int input = int.Parse(Console.ReadLine());

    switch (input)
    {
        case 1:
            angle += 90;
            break;
        case 2:
            angle += angle < 0 ? 180 : -180;
            break;
        case 3:
            angle -= 90;
            break;
    }
}

int reuslt = angle / 90;

if (reuslt == 0)
{
    Console.WriteLine("N");
}
else if (reuslt == -1)
{
    Console.WriteLine("W");
}
else if (reuslt == 1)
{
    Console.WriteLine("E");
}
else
{
    Console.WriteLine("S");
}