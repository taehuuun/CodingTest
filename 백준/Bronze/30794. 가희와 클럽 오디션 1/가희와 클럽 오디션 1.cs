string[] input = Console.ReadLine().Split();

int level = int.Parse(input[0]);
string judgment = input[1];
int score = 0;

switch (judgment)
{
    case "miss":
        score = 0;
        break;
    case "bad":
        score = level * 200;
        break;
    case "cool":
        score = level * 400;
        break;
    case "great":
        score = level * 600;
        break;
    case "perfect":
        score = level * 1000;
        break;
}

Console.WriteLine(score);