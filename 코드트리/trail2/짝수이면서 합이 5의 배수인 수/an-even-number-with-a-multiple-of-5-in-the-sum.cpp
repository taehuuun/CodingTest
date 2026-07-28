#include <iostream>
#include <string>

using namespace std;

bool fidnNum(int n)
{
    if(n % 2 != 0)
    {
        return false;
    }

    int sum = 0;
    string str = to_string(n);

    for(int i = 0 ; i < str.length(); i++)
    {
        sum += str[i] - '0';
    }

    if(sum % 5 != 0)
    {
        return false;
    }

    return true;
}

int main() 
{
    int n;

    cin >> n;

    cout << (fidnNum(n) ? "Yes" : "No");

    return 0;
}