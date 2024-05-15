namespace Coding_Practic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // text ichindagi belgilarni sonini aniqlash

            string text = "123ertyuERT4567$%^&terterw*5464";
            int numbers = 0;
            int lowerLetters = 0;
            int upperLetters = 0;
            int others = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= '0' && text[i] <= '9')
                {
                    numbers++;
                }
                else if (text[i] >= 'a' && text[i] <= 'z')
                {
                    lowerLetters++;
                }
            }
            Console.WriteLine($"Numeric chars: {numbers}");
            Console.WriteLine($"Lower letters: {lowerLetters}");
        }
    }
}
