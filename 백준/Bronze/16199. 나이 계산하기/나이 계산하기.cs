int[] birth = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int[] today = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int annual = today[0] - birth[0];
int count = annual + 1;
int america = today[1] > birth[1] || today[1] == birth[1] &&today[2] >= birth[2] ? count - 1 : count-2;

Console.WriteLine(america.ToString());
Console.WriteLine(count.ToString());
Console.WriteLine(annual.ToString());