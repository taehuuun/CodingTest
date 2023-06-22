string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int totalSpace = int.Parse(splitInput[0]);
int basketSize = int.Parse(splitInput[1]);

int basketLeft = 1;
int basketRight = basketSize;
int distance = 0;

int appleCnt = int.Parse(Console.ReadLine());

for (int i = 0; i < appleCnt; i++)
{
    int fallPos = int.Parse(Console.ReadLine());

    while (true)
    {
        if (basketLeft <= fallPos && fallPos <= basketRight)
        {
            break;
        }

        if (fallPos < basketLeft)
        {
            if (basketLeft > 1)
            {
                basketLeft--;
                basketRight--;
            }
        }
        else
        {
            if (basketRight < totalSpace)
            {
                basketLeft++;
                basketRight++;
            }
        }

        distance++;
    }
}

Console.WriteLine(distance);