using System;

public class Solution
{
    public static int FindRepeat(int[] numbers)
    {
        // Find the number that appears twice
        int n = numbers.Length - 1;
        int sumExpected = ( n * n + n ) / 2; //using triangular series formula
        
        for (int i = 0; i < numbers.Length; i++) {
            sumExpected -= numbers[i];
        }

        return -sumExpected;
    }
