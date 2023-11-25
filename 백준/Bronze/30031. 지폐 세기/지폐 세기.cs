int n = int.Parse(Console.ReadLine());

int totalMoney = 0;

for (int i = 0; i < n; i++)
{
    int[] size = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

    switch (size[0])
    {
        case 136:
            totalMoney += 1000;
            break;
        case 142:
            totalMoney += 5000;
            break;
        case 148:
            totalMoney += 10000;
            break;
        case 154:
            totalMoney += 50000;
            break;
    }
}

Console.WriteLine(totalMoney);