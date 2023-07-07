int[] input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

int setX = input[0] % input[1] == 0 ? (input[0] / input[1]) * input[2] : (input[0] / input[1] + 1) * input[2];
int setY = input[0] % input[3] == 0 ? (input[0] / input[3]) * input[4] : (input[0] / input[3] + 1) * input[4];

Console.WriteLine(Math.Min(setX,setY)); 