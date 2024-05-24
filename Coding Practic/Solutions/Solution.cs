namespace Coding_Practic.Solutions;

public partial class Solution : ISolution
{

    internal void FindMinAndMax()
    {
        int[] maxAndMinNUnbers = { 1, 10, 20, 30 };
        FindMinAndMax(maxAndMinNUnbers);
    }
    internal void FindMin()
    {
        int[] minNumbers = { 10, 20, 8, 50, 70 };
        FindMin(minNumbers);
    }
    internal void FindMax()
    {
        int[] maxNumbers = { 10, 20, 30, 60, 50 };
        FindMax(maxNumbers);
    }

    void ISolution.FindMaxAndMinDiff(int[] numbers)
    {
        int[] diffNumber = { 1, 20, 30, 40, 550 };
        int result = FindMaxAndMinDiff(diffNumber);
        Console.WriteLine($"Differnce between maximal and minimal numbers: {result}");
    }

    internal void FindMaxAndMinDiff()
    {
        int[] diffNumber = { 1, 20, 30, 40, 5 };
        int result = FindMaxAndMinDiff(diffNumber);
        Console.WriteLine($"Differnce between maximal and minimal numbers: {result}");
    }

    internal void ReverseArray()
    {
        int[] reverseArr = {};
        ReverseArray(reverseArr);
    }
}
