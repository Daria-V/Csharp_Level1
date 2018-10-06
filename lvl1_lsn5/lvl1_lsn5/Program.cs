using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//ДЗ. Уровень 1. Урок 5. Выполнила Свидлова Дарья
namespace lvl1_lsn5
{
    class Program
    { 

        static void ClearConsole()
        {
            Console.WriteLine("\nДля продолжения нажмите Enter. Экран консоли будет очищен");
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            #region Task3
            //3. * Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.Регистр можно не учитывать:
            //а) с использованием методов C#;
            //б) *разработав собственный алгоритм.
            //Например: badc являются перестановкой abcd. 
            Console.WriteLine("Задание 3. Является ли одна строка перестановкой другой.");
            Console.WriteLine("Введите первую строку:");
            string str1 = Console.ReadLine();

            Console.WriteLine("Введите вторую строку:");
            string str2 = Console.ReadLine();

            Console.WriteLine("\nПервая строка, перевернутая стредствами C#: " + ReverseClass.ReverseString(str1));
            Console.WriteLine("\nПервая строка, перевернутая перебором элементов строки: " + ReverseClass.ReverseStringMy(str1));

            if (ReverseClass.ReverseString(str1).ToLower() == str2.ToLower()) 
                Console.WriteLine("\nСтроки являются зеркальным отражением друг друга.");
            else Console.WriteLine("\nСтроки не являются зеркальным отражением друг друга.");


            ClearConsole();
            #endregion
            #region Task4
            //4.Задача ЕГЭ.
            //* На вход программе подаются сведения о сдаче экзаменов учениками 9 - х классов некоторой средней
            //школы.В первой строке сообщается количество учеников N, которое не меньше 10, но не
            //превосходит 100, каждая из следующих N строк имеет следующий формат:
            //< Фамилия > < Имя > < оценки >,
            //где < Фамилия > — строка, состоящая не более чем из 20 символов, < Имя > — строка, состоящая не
            //более чем из 15 символов, < оценки > — через пробел три целых числа, соответствующие оценкам по
            //  пятибалльной системе. < Фамилия > и<Имя>, а также<Имя> и<оценки> разделены одним пробелом.
            //Пример входной строки:
            //Иванов Петр 4 5 3
            //Требуется написать как можно более эффективную программу, которая будет выводить на экран
            //фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики,
            //набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
  
            string path = "C:\\Users\\Nezabudka\\Desktop\\exam.txt";
            string checkStudentCountPattern = @"\b((\d{2})|(\d{2}\d{1}[^1-9]))\b";
            string checkStudentDataFormatPattern = @"[А-я]+\s[А-я]+(\s\d){3}";

            StreamReader streamReader= new StreamReader(path, Encoding.Default);
            try
            {

                
                int N = int.Parse(streamReader.ReadLine());
                if (!Regex.IsMatch(N.ToString(), checkStudentCountPattern)) throw new ArgumentException();

                double maxValue = 5; //максимальный возможный балл

                Student[] student = new Student[N];

                for (int i = 1; i <= student.Length; i++)
                {
                   
                        string str = streamReader.ReadLine();
                    if (Regex.IsMatch(str, checkStudentDataFormatPattern))
                    {
                        string[] s = str.Split(' ');
                        student[i - 1].surname_Name = String.Concat(s[0], " ", s[1]);
                        student[i - 1].mean = (Double.Parse(s[2]) + Double.Parse(s[3]) + Double.Parse(s[4])) / 3;
                        Console.WriteLine(student[i - 1].surname_Name + " " + student[i - 1].mean);
                    }
                    else
                    {
                        Array.Resize(ref student, student.Length - 1);
                        --i;
                    }
                }
                streamReader.Close();

                
                double worstMean = Student.MinMean(maxValue, student);
                double[] worstMeans = Student.MinMeans(maxValue, student, 3);

                Console.WriteLine("\nМинимальный балл: {0:#.###} ", worstMean);
                Console.WriteLine("\nМинимальные баллы: " + Student.ToString(worstMeans));

                Student[] worstStudents = Student.FindWorst(worstMeans, student);
                Console.WriteLine("\nСтуденты с минимальными баллами: \n" + Student.ToString(worstStudents));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Неверно указано количество учеников");
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }

            ClearConsole();
            #endregion

        }
    }
}
