int n = int.Parse(Console.ReadLine());
int title = 666;
string s;
 
while(true)
{
    s = title.ToString();
 
    if (s.Contains("666"))
    {
        n--;
    }
 
    if (n == 0) 
    {
        break;
    }

    title++;
}

Console.Write(title);