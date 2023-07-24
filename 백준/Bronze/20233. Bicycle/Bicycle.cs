int a = int.Parse(Console.ReadLine());
int x = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int t = int.Parse(Console.ReadLine());

Console.WriteLine($"{Fee(a,t,30,x)} {Fee(b,t,45,y)}");

int Fee(int monthlyFee,int time,int freeFeeTime, int perMinFee)
{
    int chargeFeeTime = Math.Clamp(time * 21 - freeFeeTime * 21, 0, int.MaxValue); 
    return monthlyFee + chargeFeeTime * perMinFee;
}