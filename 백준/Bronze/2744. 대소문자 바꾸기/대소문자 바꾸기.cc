#include <iostream>
#include <string>

using namespace std;

string str;

int main()
{
    cin >>str;

    for(int i = 0 ; i<str.size(); i++)
    {
        if(isupper(str[i]))
            str[i] = tolower(str[i]);
        else
            str[i] = toupper(str[i]);
    }

    cout << str;

    return 0;
}
