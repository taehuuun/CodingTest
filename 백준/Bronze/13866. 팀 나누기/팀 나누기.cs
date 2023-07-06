string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int[] arr = new int[4];

for (int i = 0; i < splitInput.Length; i++)
{
    arr[i] = int.Parse(splitInput[i]);
}

Console.WriteLine(Math.Abs(arr[0] + arr[3] - arr[1] - arr[2]));