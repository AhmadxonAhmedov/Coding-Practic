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
        int[] minNumbers = { 10, 20, 1, 50, 70 };
        FindMin(minNumbers);
    }
    internal void FindMax()
    {
        int[] maxNumbers = { 10, 20, 30, 410, 120, 65 };
        FindMax(maxNumbers);
    }
}