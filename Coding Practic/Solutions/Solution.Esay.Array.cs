using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Coding_Practic.Solutions;

public partial class Solution
{
    public void FindMax(int[] numbers)
    {
        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"Maximum number: {max}");
    }

    public void FindMin(int[] numbers)
    {
        int min = numbers[0];
        foreach (int num in numbers)
        {
            if (num < min)
            {
                min = num;
            }
        }
        Console.WriteLine($"Minimum number: {min}");
    }

    public void FindMinAndMax(int[] numbers)
    {
        int max = numbers[0];
        int min = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }
        Console.WriteLine($"Maximum number: {max}, Minimum number: {min}");
    }

    public int FindMaxAndMinDiff(int[] numbers)
    {
        // Given an array of integers,
        // return the difference between the
        // largest and smallest integers in the array .
        int max = numbers[0];
        int min = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }
            return max - min;
    }
    public void ReverseArray(int[] numbers)
    {
        int[] num = { 10, 20, 30, 40, 50 };
        int[] reverseArr = new int[num.Length];

        for (int i = 0; i < num.Length; i++)
        {
            reverseArr[i] = num[reverseArr.Length - 1 - i];
        }
        foreach (int number in reverseArr)
        {
            Console.WriteLine($"Reverse array: {number}");
        }
    }
}