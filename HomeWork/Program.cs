using System;
//using System.Globalization;

namespace HomeWork
{
    class Program
    {
        public static void Main()
        {
            for (int i = 0; i < 10; i--)
            {
                Console.WriteLine("выберите номер задания ( цифра от 1 до 5 ) или введите 0, если хотите выйти. ");
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

                if (select == 4)
                {
                    TaskFour();
                    continue;
                }

                if (select == 5)
                {
                    TaskFive();
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

        private static void TaskOne()
        {
            Console.WriteLine("Введите ваше имя");
            var name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию");
            var surname = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какой у вас рост?");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какой у вас вес?");
            var weight = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(name + " " + surname + " " + age + " " + height + " " + weight); // действие А
            Console.WriteLine("{0} {1} {2} {3} {4}", name, surname, age, height, weight); // действие Б
            Console.WriteLine($"{name} {surname} {age} {height} {weight}"); // действие В 
        }
        
        private static void TaskTwo()
        {
            // System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine("Введите ваш вес");
            var weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите ваш рост в метрах");
            var height = Convert.ToDouble(Console.ReadLine());
            var imt = weight / height / height;
            Console.Clear();
            Console.WriteLine(imt);
        }

        private static void TaskFree()
        {
            Console.WriteLine("Введите X1");
            var x1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("введите X2");
            var x2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите Y1");
            var y1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("введите Y2");
            var y2 = Convert.ToSingle(Console.ReadLine());
            Console.Clear();
            var dist = Distance(x1, x2, y1, y2); // через метод
            Console.WriteLine($"Расстояние между точками равно {dist:f2}");
            dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); // стандартное решение 
            Console.WriteLine($"Расстояние между точками равно {dist:f2}");
        }

        static double Distance( float x1, float x2, float y1, float y2)
        {
            var dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return dist;
        }
        
        private static void TaskFour()
        {
            Console.WriteLine("Введите переменную А");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите переменную B");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a; // через дополнительную переменную
            a = b;
            b = c;
            Console.WriteLine($"переменная A = {a}, а переменная B = {b}");
            
            /*
             * математический метод:
             * a = a + b;
             * b = a - b;
             * a = a - b;
             *
             * метод XOR:
             * a = a ^ b;
             * b = a ^ b;
             * a = b ^ a;
             */
        }

        private static void TaskFive()
        {
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("введите вашу фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите город вашего проживания");
            string city = Console.ReadLine();
            Console.Clear();
            TextCenter(name, surname, city);
            Console.WriteLine($"{name} {surname} {city}");
        }

        static string TextCenter(string name, string surname, string city)
        {
            var x = (Console.WindowWidth / 2) - (name.Length / 2) - (surname.Length / 2) - (city.Length / 2);
            var y = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(x, y);
            return name;
        }

        private static void TaskSix()
        {
            // TextCenter & Dictance;
        }
    }
}