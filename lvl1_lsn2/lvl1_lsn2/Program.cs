using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ДЗ Уровень 1. Урок 2. Выполнила Свидлова Дарья
namespace lvl1_lsn2
{
   
    class Program
    {
        /// <summary>
        /// Метод, ожидающий нажатия клавиши для последующей очистки окна консоли
        /// </summary>
        static void ClearConsole()
        {
            Console.WriteLine("\nДля продолжения нажмите Enter. Экран консоли будет очищен");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Метод определения максимального из трех входных параметров. Task1
        /// </summary>
        /// <param name="a">Значение числа а</param>
        /// <param name="b">Значение числа b</param>
        /// <param name="c">Значение числа c</param>
        /// <returns></returns>
        static int MAX(int a, int b, int c)
        {
            if (a > b && a > c)
            { return a; }
            else if (b > a && b > c)
                return b;
            else return c;
        }
        /*
                /// <summary>
                /// Метод подсчета количества цифр в числе. Число преобразуется в строку и подсчитывается кол-во символов. Task2
                /// </summary>
                /// <param name="_number">Введенное целое число, количество символов в котором нужно посчитать</param>
                /// <returns></returns>
                static int CountSymbols(int _number)
                {
                    int i = 0;
                    string number = _number.ToString();
                    foreach (char n in number)
                    { i++; }
                    return i;

                }
        */

        /// <summary>
            /// Метод подсчета количества цифр в числе. Task2
            /// </summary>
            /// <param name="_number">Введенное число, количество цифр в котором нужно посчитать</param>
            /// <returns>Возвращет количество цифр в числе</returns>
        static int CountIntSymbols(int _number)
        {
            int i = 0;
            int number = _number;
            do
            {
                i++;
                number /= 10; 
            } while (number != 0);
            return i;
        }

        /// <summary>
        /// Метод проверки введенных логина и пароля. Task4
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns></returns>
        private static bool CheckAuthorization()
        {
            string l = "root";
            string p = "GeekBrains";


            Console.WriteLine("Введите логин:");
            string login = Console.ReadLine();

            Console.WriteLine("Введите пароль:");
            string password = Console.ReadLine();

            if (l == login && p == password)
            {
                Console.WriteLine("Вы успешно авторизованы");
                return true;
            }
            else
            {
                Console.WriteLine("Логин и/или пароль не совпадают");
                return false;
            }

        }

        /// <summary>
        /// Метод вычисления массы тела, при которой ИМТ будет в пределах нормы. Task5
        /// </summary>
        /// <param name="h">рост человека в метрах</param>
        /// <param name="low_IMT">нижний предел нормы ИМТ</param>
        /// <param name="high_IMT">верхний предел нормы ИМТ</param>
        /// <param name="low_weight">минимальный вес в пределах нормы</param>
        /// <param name="high_weight">максимальный вес в пределах нормы</param>
        private static void PreferedWeight(double h, double low_IMT, double high_IMT, out double low_weight, out double high_weight)
        {
            low_weight = low_IMT * h * h;
            high_weight = high_IMT * h * h;

        }

        /// <summary>
        /// Метод подсчета суммы цифр в числе. Task6
        /// </summary>
        /// <returns>Возвращет сумму цифр в числе</returns>
        private static int SumOwnSymbols(int number6)
        {
            if (number6 == 0) return 0;
            else return SumOwnSymbols(number6 / 10) + (number6 % 10);
        }

        /// <summary>
        /// Метод подсчета суммы чисел в диапазоне. Task7
        /// </summary>
        /// <param name="n1">нижняя граница</param>
        /// <param name="n2">верхняя граница</param>
        /// <returns>Возвращет сумму чисел</returns>
        private static int SumNumbers(int n1, int n2)
        {
            if (n1 == n2) return n1;
            else return SumNumbers(n1 + 1, n2) + n1;
        }

        /// <summary>
        /// Метод рекурсивного вывода чисел в заданных границах. Task7
        /// </summary>
        /// <param name="n1">Стартовое число вывода</param>
        /// <param name="n2">Заключительное число вывода</param>
        private static void PrintNumbers(int n1, int n2)
        {
            if (n1 == n2) Console.WriteLine(n1);
            else
            {
                Console.Write(n1 + " ");
                PrintNumbers(n1 + 1, n2);
            }
        }
        static void Main()
        {
            #region Task1
            //Написать метод, возвращающий минимальное из трёх чисел.
            Console.WriteLine("Задание1. Вычислить максимальное значение из трех чисел.");
            int i, a, b, c;
            a = b = c = 0; //присваиваю значение, чтобы функция MAX не ругалась на неинициализированные переменные
            for (i = 1; i <= 3; i++)
            {
                Console.WriteLine("Введите целое число:");
                switch (i)
                {
                    case 1:
                        a = Int32.Parse(Console.ReadLine());
                        break;
                    case 2:
                        b = Int32.Parse(Console.ReadLine());
                        break;
                    case 3:
                        c = Int32.Parse(Console.ReadLine());
                        break;
                }
            }
            Console.WriteLine("Максимальное число из введенных Вами: " + MAX(a, b, c));
            ClearConsole();
            #endregion

            #region Task2
            //Написать метод подсчета количества цифр числа.
            Console.WriteLine("Задание2. Вывод количества цифр числа с помощью метода. \nВведите целое число:");
            int number2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Количество символов в введенном числе: " + CountIntSymbols(number2));
            ClearConsole();
            #endregion

            #region Task3
            //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечётных положительных чисел.
            Console.WriteLine("Задание3. Вводить числа, пока не будет введен 0. Подсчитать сумму всех нечетных чисел");
            int sum = 0;
            int number3;
            do {
                Console.WriteLine("Введите целое число:");
                number3 = Int32.Parse(Console.ReadLine());

                if (number3 % 2 != 0) sum += number3;               
            } while (number3 != 0);
            Console.WriteLine("Сумма нечетных чисел: " + sum);

            ClearConsole();
            #endregion

            #region Task4
            //Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
            //На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains). 
            //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
            //программа пропускает его дальше или не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками.
            Console.WriteLine("Задание4. Проверка логина и пароля с тремя попытками ввода.");
            
            i = 0;
            bool lpCheck; // переменная вывода результата проверки корректности ввода логина и пароля
            do
            {
                i++;
                Console.WriteLine("\n" + $"{i} попытка");
                lpCheck = CheckAuthorization();
                
            } while (i < 3 && lpCheck == false);

            if (!lpCheck) Console.Write("\nВы исчерпали 3 попытки. Ваша учетка заблокирована");
            

            ClearConsole();
            #endregion

            #region Task5
            //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
            //    нужно ли человеку похудеть, набрать вес или все в норме;
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            //I = m / (h * h);
            //где m — масса тела в килограммах, h — рост в метрах . Норма 18,5 < ИМТ < 24.99
            double low_IMT = 18.5;
            double high_IMT = 24.99;

            Console.WriteLine("Задание5. Вычисление ИМТ и вывод рекомендации");

            Console.WriteLine("Введите вес в кг");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("введите рост в метрах");
            double h = Convert.ToDouble(Console.ReadLine());

            double I = m / (h * h);

        
            if (I < low_IMT)
                Console.WriteLine($"ИМТ = {I:F2}. Недостаточная масса тела. Необходимо набрать вес.");
            else if (I > high_IMT)
                Console.WriteLine($"ИМТ = {I:F2}. Избыточная масса тела. Необходимо сбросить вес.");
            else
                Console.WriteLine($"ИМТ = {I:F2}. Масса тела в пределах нормы. Так держать!");

            PreferedWeight(h, low_IMT, high_IMT, out double low_weight, out double high_weight);
            Console.WriteLine("\n" + $"Оптимальный вес при Вашем росте должен быть в пределах от {low_weight:F2} до {high_weight:F2} кг.");
            ClearConsole();
            #endregion
            
            #region Task6
            //*Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.
            // Хорошим называется число, которое делится на сумму своих цифр.
            // Реализовать подсчет времени выполнения программы, используя структуру DateTime.
            Console.WriteLine("Задание 6. Подсчет кол-ва чисел, которые делятся на сумму своих цифр");
        
            Console.WriteLine("Введите меньшее число:");
            int bottom = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите большее число:");
            int roof = Int32.Parse(Console.ReadLine());

            DateTime start = DateTime.Now;

            int goodSum = 0;
            while (bottom <= roof)
            {
                if (bottom % SumOwnSymbols(bottom) == 0)
                        goodSum += bottom;
                bottom++;
            }
            Console.WriteLine("Сумма \"хороших\" чисел равна: " + goodSum);
            Console.WriteLine("Время выполнения задания 6 равно " + (DateTime.Now - start));
            ClearConsole();
            #endregion

            #region Task7
         //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);
         //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
         Console.WriteLine("Задание7. Рекурсивный вывод чисел от n1 до n2 и подсчет их суммы");

            Console.WriteLine("Введите меньшее число");
            int n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите большее число");
            int n2 = Int32.Parse(Console.ReadLine());

            Console.Write("\nЧисла из указанного диапазона: ");
            PrintNumbers(n1, n2);


            Console.WriteLine("\nСумма чисел равна " + SumNumbers(n1, n2));
            ClearConsole();
            #endregion
        }

        
    }
}
