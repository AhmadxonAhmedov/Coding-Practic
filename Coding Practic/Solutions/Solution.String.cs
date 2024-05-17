namespace Coding_Practic.Solutions;

public partial class Solution
{
    #region ChekStringCharacters
    public void CheckStringChars(string text)
    {          
        int numbers = 0;
        int lowerLetters = 0;
        int upperLetters = 0;
        int others = 0;

        foreach (var t in text)
        {
            switch (t)
            {
                case >= '1' and <= '9':
                    numbers++;
                    break;
                case >= 'a' and <= 'z':
                    lowerLetters++;
                    break;
                case >= 'A' and <= 'Z':
                    upperLetters++;
                    break;
                default:
                    others++;
                    break;
            }
        }

        Console.WriteLine($"Raqamlar: {numbers}ta");
        Console.WriteLine($"Kichik harflar: {lowerLetters}ta");
        Console.WriteLine($"Katta harflar: {upperLetters}ta");
        Console.WriteLine($"Belgilar: {others}ta");
        Console.ReadLine();
    }
    #endregion
    
}