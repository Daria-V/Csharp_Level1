using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Level 1. Lesson 1.  Daria Svidlova

namespace lvl1_lsn1
{
    class Program
    {
        static void ClearConsole()
        {
            Console.WriteLine("\nДля продолжения нажмите Enter. Экран консоли будет очищен");
            Console.ReadKey();
            Console.Clear();
        }

        // Метод вычисления расстояния между точками. Используется в Task3
        static double Distance(int x1, int x2, int y1, int y2)
        {
            double distance;
            return distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        //Методы CenterOfConsoleWindow для вывода в центре строки  центра экрана консоли. Используется для выполнения пунктов б и в Task5
        static void CenterOfConsoleWindow(int l)
        {
            int leftIndent = (Console.WindowWidth - l) / 2;
            Console.SetCursorPosition(leftIndent, Console.WindowHeight / 2);
        }
        static void CenterOfConsoleWindow(string ms, int l, int h )  // строка, длина строки, величина отступа от верхнего края
        {
            int leftIndent = (Console.WindowWidth - l) / 2; // l- длина выводимой строки
            Console.SetCursorPosition(leftIndent, h);
            MyClass.Print(ms);  //используется метод Print, созданный в отдельном классе MyClass. Task6
        }
        static void Main()
        {
           
            
            #region Task1_questionnaire
            /*  1.Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
               В результате вся информация выводится в одну строчку.
              а) используя склеивание;
              б) используя форматированный вывод;
              в) *используя вывод со знаком $.
              */
            Console.WriteLine("Анкета.");
            Console.WriteLine("Введите Ваше имя:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введите Вашу фамилию:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Введите Ваш возраст:");
            string age = Console.ReadLine();

            Console.WriteLine("Введите Ваш рост в см:");
            string height = Console.ReadLine();

            Console.WriteLine("Введите Ваш вес в кг:");
            string weight = Console.ReadLine();

            Console.WriteLine();
            // вывод с использованием склеивания
            Console.WriteLine(firstName + " " + lastName + ", Ваш возраст: " + age + ", рост: " + height + " см и вес: " + weight + " кг.");

            //форматированный вывод:
            Console.WriteLine("{0}  {1} , \nВаш возраст: {2}, \nрост: {3} см и вес: {4} кг.", firstName, lastName, age, height, weight);
            //вывод с использованием $
            Console.WriteLine($"{firstName}  {lastName} , Ваш возраст: {age}, рост: {height} см и вес: {weight} кг.");

            #endregion

            #region Task2

            // Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); 
            //где m — масса тела в килограммах, h — рост в метрах
            
            Console.WriteLine("\nИМТ человека. I = m / (h * h), где m — масса тела в килограммах, h — рост в метрах");

            //Рост и вес уже введены в Task1
            int m = Int32.Parse(weight);
            double h = Convert.ToDouble(height)/100; //переводим см в метры
            double imt = m / (h * h);
            Console.WriteLine($"{firstName} {lastName}, Ваш ИМТ равен {imt:###.##}");
            #endregion

            ClearConsole();
            
            #region Task3
            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
            //по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            //Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            
            Console.WriteLine("Задание 3. \nПодсчет расстояния между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2). ");
            Console.WriteLine("Введите координату х1:");
            int x1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату х2:");
            int x2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату y1:");
            int y1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату y2:");
            int y2 = Int32.Parse(Console.ReadLine());

            var r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"\nРасстояние между точками с указанными координатами равно {r:F2}");

            //б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
            var r1 = Distance(x1,x2,y1,y2);
            Console.WriteLine($"\nВызов метода Distance. \nРасстояние между точками с указанными координатами равно {r1:F2}");
            #endregion

            ClearConsole();

            #region Task4
            /* Написать программу обмена значениями двух переменных.
             а) с использованием третьей переменной;*/

            int var1 = 1;
            int var2 = 9;
            Console.WriteLine($"Задание 4. \nЗначения переменных: var1 = {var1}, var2 = {var2}");

            int var3 = var2;
            var2 = var1;
            var1 = var3;
            Console.WriteLine($"Значения переменных после перестановки с использованием третьей переменной: var1 = {var1}, var2 = {var2}");

            //б) *без использования третьей переменной.
            var1 = var1 + var2;
            var2 = var2 - var1;
            var2 = -var2;
            var1 = var1 - var2;
            Console.WriteLine($"\nЗначения переменных после повторной перестановки БЕЗ использования третьей переменной: var1 = {var1}, var2 = {var2}");
            #endregion

            ClearConsole();

            #region Task5
            // а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            // имя и фамилию вводили в задании 1 и сохраняли в переменные firstName и lastName
            Console.WriteLine("Задание 5. \nВведите город вашего проживания:");
            var city = Console.ReadLine();
            string personalInfo = $"{firstName} {lastName} проживает в городе {city}.";
            Console.WriteLine("\t\t" + personalInfo);
            //          б) Сделать задание, только вывод организуйте в центре экрана
            
            ClearConsole();
            Console.WriteLine("Пункт б. Вывод в центре экрана. Выполнено с применением метода с 1 параметром");

            CenterOfConsoleWindow(personalInfo.Length);
            Console.WriteLine(personalInfo);
            //          в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)
            ClearConsole();
            Console.WriteLine("Пункт в. Вывод в центре экрана. Выполнено с применением метода с 3 параметрами и методом Print из класса MyClass");

            CenterOfConsoleWindow(personalInfo, personalInfo.Length, Console.WindowHeight / 2);


            #endregion
            ClearConsole();
        }
    }
}
