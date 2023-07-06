int y = int.Parse(Console.ReadLine());
int x = int.Parse(Console.ReadLine());

string result = "";

for (int i = 0; i < y; i++)
{
    result += new string('*', x) + "\n"; 
}

Console.Write(result);