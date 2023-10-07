string number  = Console.ReadLine()!;

int zeroCnt = 0;

for (int i = 0; i < number.Length; i++)
{
    if (number[i] == '0') zeroCnt++;
}

for (int i = number.Length - 1; i != 0; i--) 
{
    if (number[i] == '0') zeroCnt--;
    else break ;
}

Console.WriteLine(zeroCnt);