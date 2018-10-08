using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;



//ДЗ. Уровень 1. Урок 6. Выполнила Свидлова Дарья
namespace lvl1_lsn6
{
    /// <summary>
    /// Делегат. Task1
    /// </summary>
    /// <param name="a"></param>
    /// <param name="x"></param>
    /// <returns></returns>
    public delegate double DelegateForTable(double a, double x);

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

        

        static void Main(string[] args)
        {
        //    #region Task1
        //    //1.Изменить программу вывода функции так, чтобы можно было передавать функции типа double(double, double).
        //    //    Продемонстрировать работу на функции с функцией a*x ^ 2 и функцией a* sin(x).

        //    Console.WriteLine("Задание1. Таблица функций");

        //    Console.WriteLine("Введите параметр а");
        //    double a = Convert.ToDouble(Console.ReadLine());

        //    Console.WriteLine("Введите параметр x");
        //    double x = Convert.ToDouble(Console.ReadLine());

        //    Console.WriteLine("Введите параметр x1( x1 > x, при выводе таблицы шаг увеличения Х равен 10)");
        //    double x1 = Convert.ToDouble(Console.ReadLine());

        //    Console.WriteLine("\nПрименение функции a*x*x:");
        //    Functions.Table(new DelegateForTable(Functions.Function1), a, x, x1);

        //    Console.WriteLine("\nПрименение функции a*sin(x):");
        //    Functions.Table(new DelegateForTable(Functions.Function2), a, x, x1);

        //    ClearConsole();
        //    #endregion

        

            #region Task3
            //3.Переделать программу «Пример использования коллекций» для решения следующих задач:
            //a) Подсчитать количество студентов учащихся на 5 и 6 курсах;
            //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
            //в) отсортировать список по возрасту студента;
            //г) *отсортировать список по курсу и возрасту студента;
            //д) разработать единый метод подсчета количества студентов по различным параметрам выбора с помощью делегата и методов предикатов.

            List<Student> studentList = new List<Student>();
            StreamReader streamReader = new StreamReader("students.csv", Encoding.Default);

            //Наполняем список студентов, построчно считывая содержимое файла
            while (!streamReader.EndOfStream)
            {
                try
                {
                    string[] str = streamReader.ReadLine().Split(';');
                    studentList.Add(new Student(str[0], str[1], str[2], str[3], str[4], Int32.Parse(str[5]), Int32.Parse(str[6]), Int32.Parse(str[7]), str[8]));
                }
                catch
                {

                }
                
            }
            streamReader.Close();

            Console.WriteLine("Содержимое файла: \n");
            foreach (var student in studentList) Console.WriteLine(student.ToString());

            //a) Подсчитать количество студентов учащихся на 5 и 6 курсах;
            Console.WriteLine("\nМагистры:");
            foreach (Student student in studentList.FindAll(Student.FoundMagistr))
            {
                Console.WriteLine(student.ToString());
            }
            int countMagistr = studentList.FindAll(Student.FoundMagistr).Count;
            Console.WriteLine(String.Concat("Количество магистров: ",countMagistr));

            //Сортируем по возрасту
            AgeComparer sortByAge = new AgeComparer();
            studentList.Sort(sortByAge);

            Console.WriteLine("\n ______Отсортировано по возрасту:________ \n" );
            foreach(var student in studentList) Console.WriteLine(student.ToString());

            
            /////////////////////////////////////////////////////////////////////////////
            //Сортируем по курсу
            CourseComparer sortByCourse = new CourseComparer();
            studentList.Sort(sortByCourse);

            Console.WriteLine("\n ______Отсортировано по курсу_______ \n");
            foreach (var student in studentList) Console.WriteLine(student.ToString());


            //Сортируем по курсу и возрасту
            var sortedByAgeAndCourse = studentList.OrderBy(s => s.age).ThenBy(s => s.course).ToList();
            Console.WriteLine("\n ______Отсортировано по возрасту и курсу_______ \n");
            foreach (var st in sortedByAgeAndCourse)
                Console.WriteLine(st.ToString());


            ClearConsole();
            #endregion

        }

       
    }
}
