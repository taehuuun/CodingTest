#include <iostream>
using namespace std;

bool IsLengthVerification(int aLen, int bLen)
{
    return aLen >= bLen;
}

bool IsContinuousSubsequence(int arr1[], int arr2[], int n1Len, int n2Len)
{
    for(int i = 0; i < n1Len; i++)
    {
        if(!IsLengthVerification(n1Len, n2Len))
        {
            return false;
        }

        if(arr1[i] == arr2[0])
        {
            bool isSequence = true;

            for(int j = 0; j < n2Len; j++)
            {
                if(arr1[j + i] != arr2[j])
                {
                    isSequence = false;
                    break;
                }
            }

            if(isSequence)
            {
                return true;
            }
        }
    }

    return false;
}

int main() 
{
    // 1. n1을 순회
    // 2. 비교를 해야 할 n2의 길이가 n1의 현재 남은길이보다 길면 -> 연속 부분 수열이 아님
    // 3. n1 i번째 값이 n2의 0번째 값과 일치 할 경우 isSequence 값 true 후 내부 for문을 n2 길이 만큼 i+1번째 부터 순회 시작
    // 4. n1[i + j] 의 값과 n2[i+j]의 값이 서로 다를 경우 -> 플래그 변경 후 내부 for문 break
    // 5. 플래그 값이 여전히 true 라면 -> 연속 부분 수열 임
    // 6. 플래그 값이 false 라면 -> for문 계속 진행

    int a, b, n1[101], n2[101];

    cin >> a >> b;

    for(int i = 0; i < a; i++)
    {
        cin >> n1[i];
    }

    for(int i = 0; i < b; i++)
    {
        cin >> n2[i];
    }

    cout << (IsContinuousSubsequence(n1, n2, a, b) ? "Yes" : "No");

    return 0;
}