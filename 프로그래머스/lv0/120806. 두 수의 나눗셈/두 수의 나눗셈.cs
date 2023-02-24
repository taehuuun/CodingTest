using System;

public class Solution 
{
    public int solution(int num1, int num2) 
    {
        // num1과 num2 나눈값에 1000을 곱해 리턴
        return (int)(((double)num1/(double)num2) * 1000);
    }
}