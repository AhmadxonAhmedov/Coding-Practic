


namespace Coding_Practic.Solutions;

public partial class Solution
{
    private object num;

    public void BasketBall(int[] x, int[] y)
    {
        // Ikkita jamoa bor, jamoalar array ko'rinishda gollar sonini kiritadi
        // g > 3 = 1 ball, g > 3 = 2 ball va g > 5 = 3 ball beriladi
        // ya'ni sonlar gollar qanchalik uzoqlikdan kiritilganini bildiradi
        // arrardagi sonlar esa ularning sonini
        // [3,3,5,5,2,2] = 12 ball
       
        Solution solution = new Solution();
        Console.WriteLine($"X jamoaning ballari: {solution.CalculationTotalBalls(x)}");
        Console.WriteLine($"Y jamoaning ballari: {solution.CalculationTotalBalls(y)}");

    }

    public void PalindromeCounts(int[] x)
    {
        // array kiritiladi, undagi palindrom sonlar nechta ekanligini chiqaring
        // [12,345,343,4554,23] = 2 ta
        int[] number = {100, 232, 65, 56, 1122, 101 };
        int polimdromeCount = 0;
        foreach(int numberItem in number)
        {
            if(Polindrome(numberItem))
            polimdromeCount++;
        }
        Console.WriteLine($"Polindrom raqamlar soni: {polimdromeCount}");

    }

    internal void DoubleDonuts()
    {
        string[] inputArray = {"1", "2", "0", "00", "3" };
        string[] outputArray = inputArray.Select(s =>  s.Replace("0", "00")).ToArray();
        Console.WriteLine("Input array: [" + string.Join(", ", inputArray) + "]");
        Console.WriteLine("Output array: [" + string.Join(", ", outputArray) + "]");
    }

    internal void Polindrome()
    {
        int[] number = { 100, 232, 65, 56, 1122, 101 };
        int polimdromeCount = 0;
        foreach (int numberItem in number)
        {
            if (Polindrome(numberItem))
                polimdromeCount++;
        }
        Console.WriteLine($"Polindrom raqamlar soni: {polimdromeCount}");
    }
}