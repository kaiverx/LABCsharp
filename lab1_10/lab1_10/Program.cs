//Даны три различных целых числа. Определить, какое из них (первое, второе или третье):
//а) самое большое; б) самое маленькое; в) является средним (средним назовем число, которое больше
//наименьшего из данных чисел, но меньше наибольшего).

namespace NumberComparison
{
    public class Logic
    {
        /**
         * Метод для определения самого большого, среднего и самого маленького числа
         */
        public static (int max, int mid, int min) GetSorted(int first, int second, int third)
        {
            int[] numbers = { first, second, third };
            Array.Sort(numbers);
            return (numbers[2], numbers[1], numbers[0]);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 целых числа:");

            // Читаем три числа с консоли
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            // Вызываем метод для обработки чисел
            var (max, mid, min) = Logic.GetSorted(first, second, third);

            // Выводим результат
            Console.WriteLine($"{max} - Наибольшее число, {mid} - Среднее число, {min} - Наименьшее число");
            Console.ReadLine();
        }
    }
}
