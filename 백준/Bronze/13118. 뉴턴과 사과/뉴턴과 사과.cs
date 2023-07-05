string inputPerson = Console.ReadLine();
string[] splitInputPerson = inputPerson.Split(' ');

string inputApple = Console.ReadLine();
string[] splitInputApple = inputApple.Split(' ');

int idx = 0;

for (int i = 0; i < splitInputPerson.Length; i++)
{
    if (splitInputPerson[i] == splitInputApple[0])
    {
        idx = i + 1;
        break;
    }
}

Console.WriteLine(idx);