string input = Console.ReadLine();

if (input.Length == 2)
{
    // 1 <= a <= 9, 1 <=b <=9   | n의 길이가 2글자
    Console.WriteLine((input[0] - '0') + (input[1] - '0'));
}
else if (input.Length == 3)
{
    if (input[1] == '0')
    {
        // a = 10, 1<= b <=9        | n의 길이가 3글자
        Console.WriteLine(10 + (input[2]-'0'));
    }
    else
    {
        // 1<= a <= 9, b = 10       | n의 길이가 3글자    
        Console.WriteLine(10 + (input[0]-'0'));
    }
}
else
{
    // a = 10, b = 10           | n의 길이가 4글자
    Console.WriteLine(20);
}