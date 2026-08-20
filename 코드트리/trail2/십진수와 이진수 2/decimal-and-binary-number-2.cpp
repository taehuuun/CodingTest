#include <iostream>
#include <algorithm>
#include <string>

using namespace std;

int ToDecimal(string binary)
{
    int num = 0;

    for(int i = 0; i < binary.length(); i++)
    {
        num = num * 2 + (binary[i] - '0');
    }

    return num;
}

string ToBinary(int decimal)
{
    string binary;

    while(true)
    {
        if(decimal < 2)
        {
            binary += (decimal + '0');
            break;
        }

        binary += ((decimal % 2) + '0');
        decimal /= 2;
    }

    reverse(binary.begin(), binary.end());

    return binary;
}

int main() 
{
    string binary, result;

    cin >> binary;

    int decimal = ToDecimal(binary);

    result = ToBinary(decimal * 17);

    cout << result;

    return 0;
}