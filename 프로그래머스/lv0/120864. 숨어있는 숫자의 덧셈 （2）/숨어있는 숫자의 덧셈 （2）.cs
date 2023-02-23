using System;

public class Solution 
{
    public int solution(string my_string) 
    {
        int answer = 0;
        
        // 마지막 자연수를 처리하기 위해 의미없는 아무값이나 추가
        my_string += "Q";

        // i+1 비교 연산을 위해 my_string의 길이-1 만큼 반복
        for (int i = 0; i < my_string.Length-1; i++)
        {
            // i번째 문자가 숫자인지 체크
            // 숫자가 아니라면 패스
            if (Char.IsDigit(my_string[i]))
            {
                // i+1번째 문자가 숫자인지 체크
                // 숫자라면 추가 반복문을 통해 연속되는 숫자 체크
                // 아니라면 i번째 숫자만 sum에 더함
                if (Char.IsDigit(my_string[i+1]))
                {
                    // 연속되는 숫자를 처리하기 위해 임시 빈 문자열 생성
                    string tmpStr = "";
                    
                    // j만큼 인덱스를 체크할것이기 때문에
                    // 어디까지 체크를 했는지 인덱스를 저장할 변수
                    int checkIdx = 0;
                    
                    // i부터 my_string길이-1 만큼 반복
                    for (int j = i; j < my_string.Length - 1; j++)
                    {
                        // j번째 (i + a)가 숫자라면 tmpStr에 해당 문자를 더함
                        // j값을 checkIdx에다가 대입
                        // j번째 문자가 숫자가 아니라면 반복문 종료
                        if (Char.IsDigit(my_string[j]))
                        {
                            tmpStr += my_string[j];
                            checkIdx = j;
                        }
                        else
                        {
                            break;
                        }
                    }
                    
                    // 마지막 checkIdx를 i에다가 대입
                    i = checkIdx;
                    
                    // tmpStr을 정수값으로 변환 하여 answer에 더함
                    answer += int.Parse(tmpStr);
                }
                else
                {
                    // char형은 '0'을 뺄때 정수값이 나옴
                    // 변환된 정수값을 answer에 더함
                    int curChartoInt =my_string[i] - '0';
                    answer += curChartoInt;
                }
            }
        }
        return answer;
    }
}