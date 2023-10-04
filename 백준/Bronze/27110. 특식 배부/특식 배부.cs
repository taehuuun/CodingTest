int n = int.Parse(Console.ReadLine());
int[] chickens = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

int sum = Math.Clamp(chickens[0],1,n) + Math.Clamp(chickens[1],1,n) + Math.Clamp(chickens[2],1,n);

Console.WriteLine(sum);