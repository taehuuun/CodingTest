int n = int.Parse(Console.ReadLine());
string str = Console.ReadLine();

int count = 0;

for (int i = 0; i < str.Length; i++)
{
    switch (str[i])
    {
        case 'j':
        case 'i':
            count += 2;
            break;
        case 'o':
            count += 1;
            break;
    }
}

Console.WriteLine(count);