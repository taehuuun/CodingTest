#include <iostream>
#include <string>

using namespace std;

class Home
{
    public:
        string name;
        string streetNumber;
        string region;
    
    public:
        Home() 
        {
            this->name = "";
            this->streetNumber = "";
            this->region = "";
        }
};

int main() 
{
    const int MAX_SIZE = 10;
    int n, lastIdx = 0;

    Home homes[MAX_SIZE];

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        cin >> homes[i].name >> homes[i].streetNumber >> homes[i].region;

        if(homes[i].name > homes[lastIdx].name)
        {
            lastIdx = i;
        }
    }

    cout << "name " << homes[lastIdx].name << endl;
    cout << "addr " << homes[lastIdx].streetNumber << endl;
    cout << "city " << homes[lastIdx].region;

    return 0;
}