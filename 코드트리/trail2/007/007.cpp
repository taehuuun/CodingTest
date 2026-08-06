#include <iostream>
#include <string>

using namespace std;

class Agent
{
    public:
        string secretCode;
        char place;
        int time;
};

int main() 
{
    Agent agent;

    cin >> agent.secretCode >> agent.place >> agent.time;

    cout << "secret code : " << agent.secretCode << endl;
    cout << "meeting point : " << agent.place << endl;
    cout << "time : " << agent.time;

    return 0;
}