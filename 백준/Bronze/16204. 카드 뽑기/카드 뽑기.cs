int[] inputData = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

int n = inputData[0];
int m = inputData[1];
int k = inputData[2];

int sum = 0;

sum += m <= k ? m : k;
sum += n-m <= n-k ? n-m : n-k; 

Console.WriteLine(sum);