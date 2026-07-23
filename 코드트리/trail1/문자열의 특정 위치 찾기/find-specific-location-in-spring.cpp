#include <iostream>
#include <string>
using namespace std;

int main() 
{
    string input;
    char c;

    cin >> input >> c;

    if(input.find(c) != string::npos)
    {
        cout << input.find(c);
    }
    else
    {
        cout << "No";
    }

    return 0;
}