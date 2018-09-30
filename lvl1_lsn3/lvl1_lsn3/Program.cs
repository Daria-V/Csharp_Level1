using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//C# Уровень1. Урок 3. Выполнила Дарья Свидлова
namespace lvl1_lsn3
{

    class Program
    {
        /// <summary>
        /// Структура комплексного числа. Task1
        /// </summary>
        struct Complex
        {
            public double im;
            public double re;

            /// <summary>
            /// Метод вычитания комплексных чисел. Структуры. Task1
            /// </summary>
            /// <param name="x">Комплексное число, которое нужно отнять от текущего</param>
            /// <returns></returns>
            public Complex Minus(Complex x)
            {
                Complex y;
                y.im = im - x.im;
                y.re = re -x.re;
                return y;
            }
            public string ToString()
            {
                return $"{re} + ({im})i";
            }
        }
        /// <summary>
        /// Метод, ожидающий нажатия клавиши для последующей очистки окна консоли
        /// </summary>
        static void ClearConsole()
        {
            Console.WriteLine("\nДля продолжения нажмите Enter. Экран консоли будет очищен");
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            #region Task1
            //a) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры;
            
            double im1, im2, re1, re2;
            Console.WriteLine("Задание 1. Работа с комплексными числами. Структура.");

            Console.WriteLine("Введите действительную часть первого комплексного числа:");
            re1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент мнимой части первого комплексного числа:");
            im1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите действительную часть второго комплексного числа:");
            re2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент мнимой части второго комплексного числа:");
            im2 = Double.Parse(Console.ReadLine());

            Complex complex1;
            complex1.im = im1;
            complex1.re = re1;

            Complex complex2;
            complex2.im = im2;
            complex2.re = re2;

            Complex result = complex1.Minus(complex2);
            Console.WriteLine("Разность комплексных чисел: " + result.ToString());

            ClearConsole();

            Console.WriteLine("Задание 1. Работа с комплексными числами. Класс.");
            //б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;

            ComplexClass x1 = new ComplexClass(re1, im1);
            ComplexClass x2 = new ComplexClass(re2, im2);

            Console.WriteLine("Введенные ранее комплексные числа: \n {0} \n {1}", x1.ToString(), x2.ToString());
            Console.WriteLine("\nРазность комплексных чисел: {0}", x1.Minus(x2).ToString());
            Console.WriteLine("\nПроизведение комплексных чисел: {0}", x1.Multiply(x2).ToString());

            ClearConsole();
            #endregion

            #region Task2
            //а) С клавиатуры вводятся числа, пока не будет введен 0(каждое число в новой строке).
            //   Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;

            //б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
            //   При возникновении ошибки вывести сообщение.
            Console.WriteLine("Задание2. Подсчет нечетных положительных чисел.");
            int sum = 0;
            string oddNumbers = "";
            int number2;
            try
            {
                do
                {
                    Console.WriteLine("Введите целое число:");
                    number2 = int.Parse(Console.ReadLine());

                    if ((number2 % 2 != 0) && (number2 > 0)) { sum += number2; oddNumbers += $"{number2} "; }

                } while (number2 != 0);
                Console.WriteLine($"Сумма нечетных чисел {oddNumbers}равна {sum}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Допустимы только целые числа.");
            }
            
            ClearConsole();
            #endregion

            #region Task3
            //*Описать класс дробей -рациональных чисел, являющихся отношением двух целых чисел.
            //Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса. Достаточно решить 2 задачи.Все программы сделать в одном решении.
            //**Добавить проверку, чтобы знаменатель не равнялся 0.Выбрасывать исключение
            //ArgumentException("Знаменатель не может быть равен 0");
            
            Console.WriteLine("Задание 3. Операции с дробями.");

            Console.WriteLine("Числитель первой дроби:");
            int numerator1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Знаменатель первой дроби:");
            int denominator1 = Int32.Parse(Console.ReadLine());



            Console.WriteLine("Числитель второй дроби:");
            int numerator2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Знаменатель второй дроби:");
            int denominator2 = Int32.Parse(Console.ReadLine());
            try
            {
                if (denominator1 == 0 || denominator2 == 0)
               throw new DivideByZeroException();

              Fraction q1 = new Fraction(numerator1, denominator1);

                Fraction q2 = new Fraction(numerator2, denominator2);

                Console.WriteLine("Первая дробь: {0} / {1} \nВторая дробь: {2} / {3}", q1.numerator, q1.denominator, q2.numerator, q2.denominator);


                Fraction resultPlus = q1.Plus(q2);
                Console.WriteLine("Результат сложения(double): {0:###.##} \nРезультат сложения(string): {1}", resultPlus.quotient, resultPlus.ToString());

                Fraction resultMinus = q1.Minus(q2);
                Console.WriteLine("\nРезультат вычитания(double): {0:###.##} \nРезультат вычитания(string): {1}", resultMinus.quotient, resultMinus.ToString());

                Fraction resultMultiply = q1.Multiply(q2);
                Console.WriteLine("\nРезультат умножения(double): {0:###.##} \nРезультат умножения(string): {1}", resultMultiply.quotient, resultMultiply.ToString());

                Fraction resultDivide = q1.Divide(q2);
                Console.WriteLine("\nРезультат деления(double): {0:###.##} \nРезультат деления(string): {1}", resultDivide.quotient, resultDivide.ToString());
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Знаменатель не может быть равен 0 \n");
            }


            ClearConsole();
            #endregion


        }
    }
}
