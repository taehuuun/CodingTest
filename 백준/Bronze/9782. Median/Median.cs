// n 이 홀수 인 경우 = (n+1)/2
// n 이 짝수 인 경우 = ((n/2) + ((n/2)+1))/2 

int count = 1;
while (true)
{
    string input = Console.ReadLine();

    if (input == "0")
    {
        return;
    }

    string[] splitInput = input.Split(' ');

    int size = int.Parse(splitInput[0]);
    float result = size % 2 == 0 ? (float.Parse(splitInput[size / 2]) + float.Parse(splitInput[size / 2 + 1])) / 2 :float.Parse(splitInput[size / 2+1]) ;
    Console.WriteLine($"Case {count}: {result:0.0}");
    count++;
}
