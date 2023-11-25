int n = int.Parse(Console.ReadLine());

string input = Console.ReadLine();

int vertical = 0;
int horizontal = 0;

for (int i = 0; i < n; i++)
{
    switch (input[i])
    {
        case 'N':
            vertical++;
            break;
        case 'S':
            vertical--;
            break;
        case 'E' :
            horizontal++;
            break;
        case 'W' :
            horizontal--;
            break;
    }
}

Console.WriteLine(Math.Abs(vertical) + Math.Abs(horizontal));