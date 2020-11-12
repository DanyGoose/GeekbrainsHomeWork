using System;
//using System.Globalization;

namespace HW
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Вам необходимо авторизироваться, для продолжения нажмите любую клавишу");
            Console.ReadKey();
            Console.Clear();
            int error = 0;
            LogPass(error);
            for (int i = 0; i < 10; i--)
            {
                Console.WriteLine("выберите номер задания ( цифра от 1 до 3 ) или введите 0, если хотите выйти. ");
                int select = Convert.ToInt32(Console.ReadLine());
                if (select == 1)
                {
                    TaskOne();
                    continue;
                }

                if (select == 2)
                {
                    TaskTwo();
                    continue;
                }

                if (select == 3)
                {
                    TaskFree();
                    continue;
                }

                if (select == 0)
                {
                    Console.WriteLine("До свидания!");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("такого задания в списке нет");
                }
            }
        }

        public static void TaskOne()
        {
            Console.WriteLine("введите первое число");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите третье число");
            int three = Convert.ToInt32(Console.ReadLine());
            int result = MinNumber(one, two, three);
        }


        public static int MinNumber(int one, int two, int three)
        {
            if (one < two && one < three)
                Console.WriteLine($"Минимальное число {one}");
            else if (two < one && two < three)
                Console.WriteLine($"Минимальное число {two}");
            else if (one == two || one == three || three == two)
                Console.WriteLine($"Все числа должны отличаться друг от друга!");
            else
                Console.WriteLine($"Минимальное число {three}");
            return 0;
        }

        public static void TaskTwo()
        {
            Console.WriteLine("введите целое число");
            int number = Convert.ToInt32(Console.ReadLine());
            string result = Convert.ToString(number);
            Console.WriteLine($"в числе {result.Length} цифр(ы)");
        }

        public static void TaskFree()
        {
            Console.WriteLine("введите любое целое число");
            int result = 0;
            do
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                    Console.WriteLine(result);
                    break;
                }

                if (number % 2 != 0 && number > 0)
                    result += number;
                Console.WriteLine("введите любое целое число, либо 0, если хотите узнать сумму");
            } while (true);
        }

        public static int LogPass(int error)
        {
            do
            {
                Console.WriteLine("введите логин");
                var log = Convert.ToString(Console.ReadLine());
                Console.WriteLine("введите пароль");
                var pass = Convert.ToString(Console.ReadLine());
                if (log == "GeekBrains" && pass == "root")
                {
                    Console.WriteLine("вы успешно авторизировались!");
                    break;
                }
                else
                {
                    Console.WriteLine("данные неверны");
                    error++;
                    if (error == 2)
                        Console.WriteLine("Упс, кажется вы пытаетесь нас взломать!");
                    if (error == 3)
                        Console.WriteLine("...но у вас не выходит.");
                }
            } while (error < 3);

            return 0;
        }
    }
}    
