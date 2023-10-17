int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] basket = new int[nm[0]];

for (int i = 1; i <= basket.Length; i++)
{
    basket[i-1] = i;
}

for (int i = 0; i < nm[1]; i++)
{
    int[] reverse = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    
    Array.Reverse(basket,reverse[0]-1,reverse[1]-reverse[0]+1);
}

Console.WriteLine(String.Join(" ",basket));