namespace Lesson3._2
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            bool firstValue, secondValue;
            string checkValue1, checkValue2;
            string textValue1, textValue2;
            Console.WriteLine("Введите значение true / false: ");
            checkValue1 = Console.ReadLine();

            if (bool.TryParse(checkValue1, out firstValue))
            {
                textValue1 = firstValue.ToString();
                Console.WriteLine("Введите значение true / false: ");
                checkValue2 = Console.ReadLine();

                if (bool.TryParse(checkValue2, out secondValue))
                {
                    textValue2 = secondValue.ToString();

                    bool A = (firstValue & secondValue);
                    bool B = (firstValue | secondValue);
                    bool C = (firstValue ^ secondValue);
                    bool D = (firstValue && secondValue);
                    bool E = (firstValue || secondValue);
                    bool F = (firstValue != secondValue);
                    Console.WriteLine($"{textValue1}&{textValue2} {"\t"}" +
                                                  $"{textValue1}|{textValue2} {"\t"}" +
                                                  $"{textValue1}^{textValue2} {"\t"}" +
                                                  $"{textValue1}&&{textValue2} {"\t"}" +
                                                  $"{textValue1}||{textValue2} {"\t"}" +
                                                  $"{textValue1}!={textValue2} {"\n"}" +
                                                 $"{A} {"\t"}{"\t"} {B} {"\t"}{"\t"} {C} {"\t"}{"\t"} {D} {"\t"}{"\t"} {E} {"\t"}{"\t"} {F}");
                }

                else
                {
                    Console.WriteLine("Вы ввели неверное значение!");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели неверное значение!");
            }
        }
    }
}
