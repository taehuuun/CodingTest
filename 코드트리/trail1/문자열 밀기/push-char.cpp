#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input;

    cin >> input;

    int len = input.length();

    input = input.substr(1, len) + input.substr(0,1);

    cout << input;

    return 0;
}