using System;

public class Solution {
    public int solution(int age) {
        
        // Ex) age = 40
        // -> 2022 - (40 - 1)
        // -> 2022 - 39
        // -> 1983
        
        return 2022 - (age -1);
    }
}