using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        // 총 요금
        long fee = 0;
        
        // 1 ~ count까지 반복 하면서
        // 총 요금을 구한다
        for(int i = 1; i <= count; i++)
        {
            fee += price * i;
        }
        
        // money-fee 값이 0 이상이면 0반환 (모자라지 않음)
        // money-fee 값이 0 미만이면 fee-money 값을 리턴 (돈이 모자름)
        return (money-fee >= 0) ? 0 : fee - money;
    }
}