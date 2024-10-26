string input = Console.ReadLine();

const int MAX_NUM = 1000000000;

string tmp = string.Empty;

for (int i = 1; i <= MAX_NUM; i++)
{
    tmp += i;

    for (int j = 0; j < tmp.Length; j++)
    {
        if (input[j] != tmp[j])
        {
            Console.WriteLine("-1");
            return;
        }
    }

    if (tmp.Length == input.Length)
    {
        Console.WriteLine(i);
        break;
    }
}