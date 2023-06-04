int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

int[] arr = new int[n];

string inputStr = Console.ReadLine();
string[] splitInput = inputStr.Split(' ');
int count = 0;

List<int> comb = new List<int>();

for (int i = 0; i < splitInput.Length; i++)
{
    arr[i] = int.Parse(splitInput[i]);
}

Combination(arr, 0,2);
Console.WriteLine(count);

void Combination(int[] arr, int idx, int depth)
{
    if (depth == 0)
    {
        int sum = 0;

        for (int i = 0; i < comb.Count; i++)
        {
            sum += comb[i];
        }

        if (sum == m)
        {
            count++;
        }

        return;
    }
    
    if(idx == arr.Length)
        return;
    
    comb.Add(arr[idx]);
    Combination(arr,idx+1, depth-1);
    
    comb.RemoveAt(comb.Count-1);
    Combination(arr,idx+1, depth);
}