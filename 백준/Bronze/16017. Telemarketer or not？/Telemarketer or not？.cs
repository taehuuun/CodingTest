char[] input = new char[4];

for (int i = 0; i < input.Length; i++)
{
    input[i] = char.Parse(Console.ReadLine());
}

if ((input[0] == '8' || input[0] == '9') && (input[1] == input[2]) && (input[3] == '8' || input[3] == '9'))
{
    Console.WriteLine("ignore");
}
else
{
    Console.WriteLine("answer");
}