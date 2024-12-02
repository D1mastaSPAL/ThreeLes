using System;
using System.ComponentModel;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson3._1
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            int number, lower, larger;
            Random rand = new Random();
            number = rand.Next(0, 101);
            lower = rand.Next(number - 2, number);
            larger = rand.Next(number + 1, number + 1);
            Console.WriteLine($"Программа загадала возраст человека в диапозоне от {lower} до {larger}.");
            int count = 0;

            while (count <= 3)
            {
                count++;
                Console.WriteLine("Чтобы узнать свою возрастную группу введите ваш возраст (полных лет) : ");
                var numberCheck = (Console.ReadLine());
                int userInput;

                if (int.TryParse(numberCheck,out userInput))
                {
                    if (userInput >= 0 & userInput < 120)
                    {
                        if (userInput == number)
                        {
                            Console.WriteLine("Верно!");
                            string category = userInput switch
                            {
                                < 2 => "Ваша возрастная группа: Младенец",
                                >= 3 and < 12 => "Ваша возрастная группа: Ребёнок",
                                >= 13 and < 17 => "Ваша возрастная группа: Подросток",
                                >= 18 and < 59 => "Ваша возрастная группа: Взрослый",
                                _ => "Ваша возрастная группа: Пожилой"
                            };

                            Console.WriteLine(category);

                            if (userInput % 2 == 0)
                            {
                                Console.WriteLine("Ваш возраст является четным числом");
                            }
                            else
                            {
                                Console.WriteLine("Ваш возраст является нечетным числом");
                            }
                        }

                        else if (userInput > number)
                        {
                            if (count == 4)
                            {
                                Console.WriteLine($"Безуспешно! Загаданное число: {number}");
                                break;
                            }
                            Console.WriteLine($"Вы не угадали :) {"\n"} Попытка № {count}: {"\n"} Попробуйте снова!");
                        }

                        else
                        {
                            if (count == 4)
                            {
                                Console.WriteLine($"Безуспешно! Загаданное число: {number}");
                                break;
                            }
                            Console.WriteLine($"Вы не угадали :) {"\n"} Попытка № {count} : {"\n"} Попробуйте снова!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Не удалось определить возраст :(");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Вы не ввели число!");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
