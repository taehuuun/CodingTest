int[] infoBill = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
int[] buyBill = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

int lottoPrice = infoBill[1];
int needLotto = 0;

for (int i = 0; i < buyBill.Length; i++)
{
    needLotto +=  buyBill[i] / lottoPrice;
}

Console.WriteLine(needLotto);