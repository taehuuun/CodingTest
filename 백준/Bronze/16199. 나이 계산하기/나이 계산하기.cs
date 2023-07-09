int[] birth = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int[] today = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

int annual = today[0] - birth[0];
int count = annual + 1;
int america = 0;

if (today[1] > birth[1] || (today[1] == birth[1]) &&(today[2] >= birth[2]) )
{
    america = count - 1;
}
else if(today[1] < birth[1] || (today[1] == birth[1]) && today[2] < birth[2])  
{
    america = count - 2;
}

Console.WriteLine(america);
Console.WriteLine(count);
Console.WriteLine(annual);