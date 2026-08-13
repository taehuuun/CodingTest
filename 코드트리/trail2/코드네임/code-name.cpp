#include <iostream>
#include <climits>

using namespace std;

class Agent
{
    public:
        char codeName;
        int score;    
};

int main() 
{
    Agent agents[5];
    int minIdx = -1;
    int minValue = INT_MAX;

    for(int i = 0; i < 5; i++)
    {
        cin >> agents[i].codeName >> agents[i].score;
    }

    for(int i = 0; i < 5; i++)
    {
        if(agents[i].score < minValue)
        {
            minValue = agents[i].score;
            minIdx = i;
        }
    }

    cout << agents[minIdx].codeName << ' ' << agents[minIdx].score;

    return 0;
}