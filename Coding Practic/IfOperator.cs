namespace Coding_Practic
{
    public class IfOperator
    {
       public void InfoOperator()
        {
            string text = "123ertyu23EkRT7+-$%^&*";
            int numbers = 0;
            int lowerLetters = 0;
            int upperLetters = 0;
            int others = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= '1' && text[i] <= '9')
                {
                    numbers++;
                }
            
                else if (text[i] >= 'a' && text[i] <= 'z')
            {
                    lowerLetters++;
            }
                else if (text[i] >= 'A' && text[i] <= 'Z')
                {
                    upperLetters++;
                }
                else
                {
                    others++;
                }
            }

            Console.WriteLine($"Raqamlar: {numbers}ta");
            Console.WriteLine($"Kichik harflar: {lowerLetters}ta");
            Console.WriteLine($"Katta harflar: {upperLetters}ta");
            Console.WriteLine($"Belgilar: {others}ta");
            Console.ReadLine();
        }     
    }
}
