#include <iostream>
#include <string>

using namespace std;

int main() 
{
    string input;

    cin >> input;

    input[1] = 'a';
    input[input.length()-2] = 'a';

    cout << input;

    return 0;
}