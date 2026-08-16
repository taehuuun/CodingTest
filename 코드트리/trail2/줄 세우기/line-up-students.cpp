#include <iostream>
#include <algorithm>

using namespace std;

class Student
{
    public:
        int index;
        int height;
        int weight;
};

bool Compare(const Student& a, const Student& b)
{
    if(a.height == b.height)
    {
        if(a.weight == b.weight)
        {
            return a.index < b.index;
        }
        else
        {
            return a.weight > b.weight;
        }
    }
    else
    {
        return a.height > b.height;
    }
}

int main() 
{
    const int MAX_SIZE = 1000;
    Student students[MAX_SIZE];
    int n;

    cin >> n;

    for(int i = 0 ; i < n; i++)
    {
        students[i].index = i + 1;

        cin >> students[i].height >> students[i].weight;
    }

    sort(students, students + n, Compare);

    for(int i = 0 ; i < n; i++)
    {
        cout << students[i].height << ' ' << students[i].weight << ' ' << students[i].index << '\n';
    }

    return 0;
}