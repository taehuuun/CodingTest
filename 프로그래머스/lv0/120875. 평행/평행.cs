using System;

public class Solution 
{
    public int solution(int[,] dots) 
    {
        // Ex) [[1, 4], [9, 2], [3, 8], [11, 6]]
        // 각 케이스별 [x1,y1] [x2,y2]가 일치 하는지 체크
        bool overLap1 = (dots[0, 0] == dots[2, 0] && dots[0, 1] == dots[2, 1]) &&
                        (dots[1, 0] == dots[3, 0] && dots[1, 1] == dots[3, 1]);
        bool overLap2 = (dots[0, 0] == dots[1, 0] && dots[0, 1] == dots[1, 1]) &&
                        (dots[2, 0] == dots[3, 0] && dots[2, 1] == dots[3, 1]);
        bool overLap3 = (dots[1, 0] == dots[2, 0] && dots[1, 1] == dots[2, 1]) &&
                        (dots[0, 0] == dots[3, 0] && dots[0, 1] == dots[3, 1]);
        
        // 하나라도 겹치는 경우 1리턴
        if (overLap1 || overLap2 || overLap3)
        {
            return 1;
        }

        // 각 케이스별 기울기를 구함
        double gradCase1A = (double)(dots[1, 1] - dots[0, 1]) / (double)(dots[1, 0] - dots[0, 0]);
        double gradCase1B = (double)(dots[3, 1] - dots[2, 1]) / (double)(dots[3, 0] - dots[2, 0]);
        double gradCase2A = (double)(dots[2, 1] - dots[1, 1]) / (double)(dots[2, 0] - dots[1, 0]);
        double gradCase2B = (double)(dots[3, 1] - dots[0, 1]) / (double)(dots[3, 0] - dots[0, 0]);
        double gradCase3A = (double)(dots[2, 1] - dots[0, 1]) / (double)(dots[2, 0] - dots[0, 0]);
        double gradCase3B = (double)(dots[3, 1] - dots[1, 1]) / (double)(dots[3, 0] - dots[1, 0]);
        
        // 구한 케이스별 기울기를 비교 부동소수점이기에 4자리까지 잘라 문자열로 비교
        if((gradCase1A.ToString("F4") == gradCase1B.ToString("F4"))||
           (gradCase2A.ToString("F4") == gradCase2B.ToString("F4"))||
           (gradCase3A.ToString("F4") == gradCase3B.ToString("F4")))
        {
            return 1;
        }
        else
        {
            return 0;
        }

    }
}