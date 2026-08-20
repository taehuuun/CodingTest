#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

int ToDicmal(string number, int baseSystem)
{
    int num = 0;

    for(int i = 0; i < number.length(); i++)
    {
        num = num * baseSystem + (number[i] - '0');
    }

    return num;
}

string ToBaseSytem(int decimal, int targetBaseSystem)
{
    string result;

    while(true)
    {
        if(decimal < targetBaseSystem)
        {
            result += decimal + '0';
            break;
        }

        result += (decimal % targetBaseSystem) + '0';
        decimal /= targetBaseSystem;
    }

    reverse(result.begin(), result.end());

    return result;
}

int main() 
{
    int a, b;
    string n;

    cin >> a >> b >> n;

    cout << ToBaseSytem(ToDicmal(n, a), b);

    return 0;
}