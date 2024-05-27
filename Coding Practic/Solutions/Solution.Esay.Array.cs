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

    public int CalculationTotalBalls(int[] arr)
    {
        int totalBalls = 0; 
        foreach (int num in arr)
        {
            if (num >= 5)
            {
                totalBalls += 3;
            }
            else if (num >= 3)
            {
                totalBalls += 2;
            }
            else if (num < 3)
            {
                totalBalls += 1;
            }
        }
        return totalBalls;
    }

    public void getArrays()
    {
        Console.Write("X jamoa gollar sonini kiriting xCountGoals=");
        int xCountGoals = int.Parse(Console.ReadLine());
        int[] x = new int[xCountGoals];
        for (int i = 0; i < xCountGoals; i++)
        {
            x[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Y jamoa gollar sonini kiriting yCountGoals=");
        int yCountGoals = int.Parse(Console.ReadLine());
        int[] y = new int[yCountGoals];
        for (int i = 0; i < yCountGoals; i++)
        {
            y[i] = int.Parse(Console.ReadLine());
        }

        Solution s = new Solution();
        s.BasketBall(x, y);
    }   

    public void getDoubleDonuts()
    {
        string[] inputArray = { "1", "2", "0", "00", "4" };
        string[] outputArray = inputArray.Select(s => s.Replace("0", "00")).ToArray();
        Console.WriteLine("Input array: [" + string.Join(", ", inputArray) + "]");
        Console.WriteLine("Output array: [" + string.Join(", ", outputArray) + "]");
    }
}