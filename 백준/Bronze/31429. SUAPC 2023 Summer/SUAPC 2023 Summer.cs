int input = int.Parse(Console.ReadLine());

switch (input)
{
    case 1:
        Print(12, 1600);
        break;
    case 2:
        Print(11, 894);
        break;
    case 3:
        Print(11, 1327);
        break;
    case 4:
        Print(10, 1311);
        break;
    case 5:
        Print(9, 1004);
        break;
    case 6:
        Print(9, 1178);
        break;
    case 7:
        Print(9, 1357);
        break;
    case 8:
        Print(8, 837);
        break;
    case 9:
        Print(7, 1055);
        break;
    case 10:
        Print(6, 556);
        break;
    case 11:
        Print(6, 773);
        break;
}

void Print(int solved, int penalty)
{
    Console.WriteLine($"{solved} {penalty}");
}