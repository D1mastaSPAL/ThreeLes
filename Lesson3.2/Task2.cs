namespace Lesson3._2
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            bool firstValue, secondValue;
            Console.WriteLine("Введите значение true / false: ");
            firstValue = Convert.ToBoolean(Console.ReadLine());
            string textValue1 = firstValue.ToString();
            Console.WriteLine("Введите значение true / false: ");
            secondValue = Convert.ToBoolean(Console.ReadLine());
            string textValue2 = secondValue.ToString();
            bool A = (firstValue & secondValue) ? true : false;
            bool B = (firstValue | secondValue) ? true : false;
            bool C = (firstValue ^ secondValue) ? true : false;
            bool D = (firstValue && secondValue) ? true : false;
            bool E = (firstValue || secondValue) ? true : false;
            bool F = (firstValue != secondValue) ? true : false;
            Console.WriteLine($"{textValue1}&{textValue2} {"\t"}" +
                              $"{textValue1}|{textValue2} {"\t"}" +
                              $"{textValue1}^{textValue2} {"\t"}" +
                              $"{textValue1}&&{textValue2} {"\t"}" +
                              $"{textValue1}||{textValue2} {"\t"}" +
                              $"{textValue1}!={textValue2} {"\n"}" +
                             $"{A} {"\t"}{"\t"} {B} {"\t"}{"\t"} {C} {"\t"}{"\t"} {D} {"\t"}{"\t"} {E} {"\t"}{"\t"} {F}");
        }
    }
}
