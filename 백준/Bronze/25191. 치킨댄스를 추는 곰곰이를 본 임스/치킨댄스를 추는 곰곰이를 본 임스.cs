int haveChicken = int.Parse(Console.ReadLine());
int[] service = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int chickenCnt = Math.Clamp(service[0]/2 + service[1],1, haveChicken);

Console.WriteLine(chickenCnt);