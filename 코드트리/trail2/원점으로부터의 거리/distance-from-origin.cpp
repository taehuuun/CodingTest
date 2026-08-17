#include <iostream>
#include <algorithm>
using namespace std;

class Point
{
    public:
        int index;
        int x;
        int y;
};

bool Compare(const Point& a, const Point& b)
{
    int aDis = a.x + a.y;
    int bDis = b.x + b.y;

    if(aDis == bDis)
    {
        return a.index < b.index;
    }

    return aDis < bDis;
}

int main() 
{
    const int MAX_SIZE = 1000;

    Point points[MAX_SIZE];
    int n;

    cin >> n;

    for(int i = 0; i < n; i++)
    {
        cin >> points[i].x >> points[i].y;
        points[i].index = i+1;

        if(points[i].x < 0)
        {
            points[i].x *= -1;
        }

        if(points[i].y < 0)
        {
            points[i].y *= -1;
        }
    }

    sort(points, points + n, Compare);

    for(int i = 0; i < n; i++)
    {
        cout << points[i].index << endl;
    }

    return 0;
}