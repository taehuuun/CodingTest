using System;

public class Solution 
{
    public int[] solution(int[] numbers, string direction) 
    {
        int tmp;
        // direction 값에 따라 numbers를 왼쪽 또는 오른쪽으로 shift 한다
        // 방향이 "right"인 경우, 마지막 요소를 임시 변수에 저장하고 
        // 배열을 한 칸씩 우측으로 shift 한 후 임시 변수 값을 배열의 첫 번째 요소로 대입한다
        if (direction == "right")
        {
            tmp = numbers[numbers.Length - 1];
            Array.Copy(numbers, 0, numbers, 1, numbers.Length - 1);
            numbers[0] = tmp;
        }
        
        // 방향이 "left"인 경우, 첫 번째 요소를 임시 변수에 저장하고 
        // 배열을 한 칸씩 좌측으로 shift 한 후 임시 변수 값을 배열의 마지막 요소로 대입한다
        else
        {
            tmp = numbers[0];
            Array.Copy(numbers, 1, numbers, 0, numbers.Length - 1);
            numbers[numbers.Length - 1] = tmp;
        }
        
        return numbers;
    }
}