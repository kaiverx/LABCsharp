namespace NumberComparison
{
    public class Logic
    {
        public static double Percent(string sentence)
        {
            // Проверяем, если строка пуста
            if (string.IsNullOrEmpty(sentence))
            {
                return 0.0;
            }

            // Подсчитываем количество букв в предложении
            int letterCount = sentence.Count(char.IsLetter);
            int totalCount = sentence.Length; // Общее количество символов в строке

            // Если строка не пуста, рассчитываем процент букв
            double percent = (double)letterCount / totalCount * 100;
            return percent;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string sentence = Console.ReadLine();

            // Получаем процент букв
            double percent = Logic.Percent(sentence);

            Console.WriteLine($"Доля букв в предложении: {percent:F2}%");
        }
    }
}
