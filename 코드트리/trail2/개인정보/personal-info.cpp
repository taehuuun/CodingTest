#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

class PersonData
{
    public:
        string name;
        int height;
        float weight;
};

bool CompareName(const PersonData& a, const PersonData& b)
{
    return a.name < b.name;
}

bool CompareHeight(const PersonData& a, const PersonData& b)
{
    return a.height > b.height;
}

void PrintData(PersonData* datas, int count)
{
    for(int i = 0 ; i < count; i++)
    {
        cout << datas[i].name << ' ' << datas[i].height << ' ' << datas[i].weight << endl;
    }
}

int main() 
{
    PersonData datas[5];

    for(int i = 0; i < 5; i++)
    {
        cin >> datas[i].name >> datas[i].height >> datas[i].weight;
    }

    cout << fixed;
    cout.precision(1);

    sort(datas, datas + 5, CompareName);
    cout << "name" << endl;
    PrintData(datas, 5);

    cout << endl;

    sort(datas, datas + 5, CompareHeight);
    cout << "height" << endl;
    PrintData(datas, 5);

    return 0;
}