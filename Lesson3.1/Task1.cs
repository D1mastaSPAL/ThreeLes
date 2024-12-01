namespace Lesson3._1
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш возраст (полных лет): ");
            int firstValue;
            firstValue = Convert.ToInt32(Console.ReadLine());
            if (firstValue >= 0 & firstValue < 120)
            {
                string category = firstValue switch
                {
                    < 2 => "Ваша возрастная группа: Младенец",
                    >= 3 and < 12 => "Ваша возрастная группа: Ребёнок",
                    >= 13 and < 17 => "Ваша возрастная группа: Подросток",
                    >= 18 and < 59 => "Ваша возрастная группа: Взрослый",
                    _ => "Ваша возрастная группа: Пожилой"
                };
                Console.WriteLine(category);
            }
            else
            {
                Console.WriteLine("Не удалось определить возраст :(");
            }
        }
    }
}
