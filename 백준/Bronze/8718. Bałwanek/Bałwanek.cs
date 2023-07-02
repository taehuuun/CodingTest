string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int x = int.Parse(splitInput[0]);
int k = int.Parse(splitInput[1]);

x *= 1000; 
// k가 제일 작은 경우 
int kSmallest = 7000 * k; 
if (kSmallest <= x) 
{ 
    Console.WriteLine(kSmallest); 
    return; 
}
    
// k가 가운데 
int kMiddle = 3500 * k; 
if (kMiddle <= x) 
{
    Console.WriteLine(kMiddle); 
    return;
} 
    
// k가 제일 큰 경우
int kBiggest = 1750 * k;
if (kBiggest <= x)
{ 
    Console.WriteLine(kBiggest);
    return; 
} 
// 조건 만족 못함 
Console.WriteLine(0);