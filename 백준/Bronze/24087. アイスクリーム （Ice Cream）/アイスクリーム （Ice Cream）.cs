int s = int.Parse(Console.ReadLine());
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int cost = 250;
int height = a;

for (int i = 0; i < 100; i++)
{
    if(height >= s)
        break;
    
    height += b;
    cost += 100;
}

Console.WriteLine(cost);