int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int n = input[0]; // 2
int m = input[1]; // 4
int k = input[2]; // 3
int a = input[3]; // 6
int b = input[4]; // 3
int c = input[5]; // 4

Dictionary<int, List<string>> dict = new Dictionary<int, List<string>>();

int jofferyArmy = a * n;
int robbArmy = b * m;
int stannisArmy = c * k;

int max = Math.Max(jofferyArmy, Math.Max(robbArmy, stannisArmy));

AddDict(jofferyArmy, "Joffrey");
AddDict(robbArmy, "Robb");
AddDict(stannisArmy, "Stannis");

dict[max].Sort();

string str = String.Join(" ", dict[max]);

Console.WriteLine(str);

void AddDict(int key, string value)
{
    if (!dict.ContainsKey(key))
    {
        dict.Add(key, new List<string>());
    }
    
    dict[key].Add(value);
}