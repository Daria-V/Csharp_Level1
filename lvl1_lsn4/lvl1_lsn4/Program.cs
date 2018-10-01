using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lvl1_lsn4
{/// <summary>
/// Уровень 1. Урок 4. Выполнила Свидлова Дарья
/// </summary>
    class Program
    {
        static void ClearConsole()
        {
            Console.WriteLine("\nДля продолжения нажмите Enter. Экран консоли будет очищен");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Метод, считывающий строки файла и записывающий их значения в массив строк  Task2
        /// </summary>
        /// <param name="path">путь к файлу</param>
        /// <returns>возвращает строковый массив</returns>
        public static string[] GetFromFile(string path)
            
        {
            string[] str = File.ReadAllLines(path);
            return str;
        }


        /// <summary>
        /// Метод проверки введенных логина и пароля. Task3
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns></returns>
        private static bool CheckAuthorization(string[] str)
        {
            Account user;
            user.login = str[0];
            user.password = str[1];


            Console.WriteLine("Введите логин:");
            string login = Console.ReadLine();

            Console.WriteLine("Введите пароль:");
            string password = Console.ReadLine();

            if (user.login == login && user.password == password)
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

        static void Main(string[] args)
        {
            #region Task1
            //1.Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
            // Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.
            // В данной задаче под парой подразумевается два подряд идущих элемента массива. 
            // Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
            Console.WriteLine("Задание1. Массив с ограниченным диапазоном значений. Подсчет пар с числом, кратным заданному");
            int arrLength = 20;
            int minValue = -10;
            int maxValue = 10;
            int denominator = 3;
            int step = 10;
            int factor = 2;

            MyArray arr3 = new MyArray(arrLength, minValue, maxValue);

            Console.WriteLine($"Массив элементов в диапазоне от {minValue} до {maxValue}: " + "\n" + arr3.ToString());
            Console.WriteLine($"Количество пар элементов массива, в которых хотя бы одно число делится на { denominator}: { arr3.CountCouples(denominator)}");

            ClearConsole();
            #endregion

            #region Task2
            //а) Дописать класс для работы с одномерным массивом.
            //    Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом.
            //    Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива, метод Multi, 
            //    умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов. 
            //    В Main продемонстрировать работу класса.

            try
            {
                MyArray arr4 = new MyArray(arrLength, step, minValue, maxValue);
                Console.WriteLine("Исходный массив arr4 с заданным шагом: \n" + arr4.ToString());
                Console.WriteLine("\nМассив после умножения элементов на заданный множитель: \n" + arr4.Multi(factor).ToString());

                Console.WriteLine("\nМассив после замена знаков элементов:\n" + arr4.Reverse());

                Console.WriteLine("\nСвойство. Сумма всех элементов исходного массива arr4 равна " + arr4.Sum);

                ClearConsole();

                //б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
                Console.WriteLine("Загрузка массива из файла. Укажите путь к файлу");
                string pathFrom = Console.ReadLine();

                MyArray arrayFromFile = new MyArray(GetFromFile(pathFrom));
                Console.WriteLine("Массив из файла: " + arrayFromFile.ToString());

                Console.WriteLine("Запись массива в файл. Укажите путь к файлу");
                string pathTo = Console.ReadLine();
                arrayFromFile.PutIntoFile(pathTo);

                ClearConsole();
                #endregion

                #region Task3
                //Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив. 
                //Создайте структуру Account, содержащую Login и Password.

                Console.WriteLine("Задание3. Проверка логина и пароля с тремя попытками ввода.");
                Console.WriteLine("Укажите путь к файлу, в котором хранится эталонная пара Логин - Пароль");
                string pathToLogPass = Console.ReadLine();


                int i = 0;
                bool lpCheck; // переменная вывода результата проверки корректности ввода логина и пароля
                do
                {
                    i++;
                    Console.WriteLine("\n" + $"{i} попытка");
                    lpCheck = CheckAuthorization(GetFromFile(pathToLogPass));

                } while (i < 3 && lpCheck == false);

                if (!lpCheck) Console.Write("\nВы исчерпали 3 попытки. Ваша учетка заблокирована");
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден");
            }

            catch (ArgumentException)
            {
                Console.WriteLine("Данные не введены или имеют неверный формат");
            }

            ClearConsole();
            #endregion
        }
    }
}
