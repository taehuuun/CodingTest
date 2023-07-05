int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int inputNum = int.Parse(Console.ReadLine());

    string result = inputNum % 2 == 0 ? "even" : "odd";
    
    Console.WriteLine($"{inputNum} is {result}");
}