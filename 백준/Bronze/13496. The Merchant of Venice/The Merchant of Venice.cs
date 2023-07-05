// n: 배 s : 속도 d : 남은 날짜
// di: 남은 거리  vi : 돈

int k = int.Parse(Console.ReadLine());


for (int i = 0; i < k; i++)
{
    string first = Console.ReadLine();
    string[] splitFirst = first.Split(' ');

    int n = int.Parse(splitFirst[0]);
    int speed = int.Parse(splitFirst[1]);
    int limitDay = int.Parse(splitFirst[2]);
    int moneyPaidBack = 0;

    for (int j = 0; j < n; j++)
    {
        string boatData = Console.ReadLine();
        string[] splitBoatData = boatData.Split(' ');

        int distance = int.Parse(splitBoatData[0]);
        int money = int.Parse(splitBoatData[1]);

        int calDay = distance / speed + (distance % speed == 0 ? 0 : 1);
        
        if (calDay <= limitDay)
        {
            moneyPaidBack += money;
        }
    }
    
    Console.WriteLine($"Data Set {i+1}:");
    Console.WriteLine($"{moneyPaidBack}");
    Console.WriteLine();
}