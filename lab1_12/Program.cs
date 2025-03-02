namespace SchoolMarks
{
    public class Logic
    {
        public static (int excellent, int good, int satisfactory, int bad) Schet(int[] mark)
        {
            int excellent = 0, good = 0, satisfactory = 0, bad = 0;
            foreach (var marks in mark)
            {
                switch (marks)
                {
                    case 5:
                        excellent++;
                        break;

                    case 4:
                        good++;
                        break;
                    case 3:
                        satisfactory++;
                        break;
                    case 2:
                        bad++;
                        break;
                }
            }
            return (excellent, good, satisfactory, bad);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите оценки учеников через пробел");
            List<int> marks = new List<int>();
            string marksString = Console.ReadLine();
            // Разделяем строку на отдельные элементы и пытаемся преобразовать их в числа
            string[] parts = marksString.Split(' ');

            for (int i = 0; i < parts.Length; i++)
            {
                int mark = int.Parse(parts[i]);
                if (mark < 2 || mark > 5)
                {
                    Console.WriteLine($"Неверная оценка на {i + 1} позиции");
                    continue;
                }
                marks.Add(mark);
            }
            var (excellent, good, satisfactory, bad) = Logic.Schet(marks.ToArray());
            Console.WriteLine($"количество пятярок: {excellent}\nколичество четверок: {good}\nколичество троек: {satisfactory}\nколичество двоек: {bad}");
        }
    }
}