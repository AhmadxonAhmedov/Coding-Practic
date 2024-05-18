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
        Console.WriteLine($"Maximum numbers: {max}");
        Console.WriteLine($"Minimum numbers: {min}");
    }

    public void FindMaxAndMinDiff(int[] numbers)
    {
        // Given an array of integers,
        // return the difference between the
        // largest and smallest integers in the array .
        throw new NotImplementedException();
    }

    public void ReverseArray(int[] numbers)
    {
        throw new NotImplementedException();
    }
}