using System;

public class Solution 
{
    public long solution(int r1, int r2) 
    {
        // 좌표들을 추가할 리스트
        long answer = 0;

        // x 좌표를 r2의 값까지 순회
        for (int x = 1; x <= r2; x++)
        {
            // 각 x 좌표에 대해 가능한 최대 y 좌표를 계산
            int max_y = (int)Math.Floor(Math.Sqrt(Math.Pow(r2, 2) - Math.Pow(x, 2)));

            // 각 x 좌표에 대해 가능한 최소 y 좌표를 계산
            // x가 r1보다 큰 경우, 최소 y 좌표는 0. 그렇지 않으면, r1에 대한 최소 y 좌표를 계산
            int min_y = x > r1 ? 0 : (int)Math.Ceiling(Math.Sqrt(Math.Pow(r1, 2) - Math.Pow(x, 2)));

            // 현재 x 좌표에 대해 가능한 y 좌표의 개수를 누적
            answer += max_y - min_y + 1;
        }

        // 총 개수를 4배하여 반환. (모든 사분면을 고려하기 때문)
        return answer * 4;
    }
}