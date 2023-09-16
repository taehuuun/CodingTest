int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int s = input[0];
int a = input[1];

int count = 0;

while(true)
{
    if (s < 2 || a < 2)
    {
        break;
    }

    s -= 2;
    a -= 2;
    count++;
}

Console.WriteLine(count);