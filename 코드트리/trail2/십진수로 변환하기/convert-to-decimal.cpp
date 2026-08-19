#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string binary;
    int num = 0;

    cin >> binary;

    for(int i =0; i < binary.length(); i++)
    {
        num = num * 2 + (binary[i] - '0');
    }

    cout << num;

    return 0;
}