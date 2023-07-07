#include <iostream>

using namespace std;

int main()
{
    int t;
    int a,b;
    
    scanf("%d",&t);
    
    for(int i = 0 ; i < t;i ++)
    {
        scanf("%d",&a);
        scanf("%d",&b);
        
        printf("%d\n", a+b);
    }
    
    
    return 0;
}