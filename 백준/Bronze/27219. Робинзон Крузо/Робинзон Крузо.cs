int n = int.Parse(Console.ReadLine());

int vCnt = n/5;
int iCnt = n%5;

string result = "";

for (int i = 0; i < vCnt; i++)
{
    result += "V";
}

for (int i = 0; i < iCnt; i++)
{
    result += "I";
}

Console.WriteLine(result);