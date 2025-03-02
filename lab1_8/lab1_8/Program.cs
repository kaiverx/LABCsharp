namespace NumberComparison
{
    public class Logic
    {
        public static double Percent(string sentence)
        {

            int letterCount = sentence.Count(char.IsLetter); 
            int totalCount = sentence.Length;

            double percent =  (double)letterCount / totalCount * 100;
            return percent;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string sentence = Console.ReadLine();

            double percent = Logic.Percent(sentence);

            Console.WriteLine($"Доля букв в предложении: {percent:F2}%");
        }
    }
}
