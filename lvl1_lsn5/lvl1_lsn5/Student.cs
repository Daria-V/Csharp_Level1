using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lvl1_lsn5
{
    /// <summary>
    /// surname_Name  - Фамилия и Имя ученика; mean - средний балл. Task4
    /// </summary>
    public struct Student
    {
        public string surname_Name;
        public double mean;

        /// <summary>
        /// метод поиска минимального среднего балла у ученика Student
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public static double MinMean(double maxValue, Student[] student)
        {
            double minMean = maxValue;

            for (int i = 0; i < student.Length; i++)
            {
                if (student[i].mean < minMean) minMean = student[i].mean;
            }
            return minMean;
        }

        public static double MinMean(double maxValue, Student[] student, double excluded_minMean)
        {
            double minMean = maxValue;

            for (int i = 0; i < student.Length; i++)
            {
                if (student[i].mean < minMean & student[i].mean > excluded_minMean)
                    minMean = student[i].mean;
            }
            return minMean;
        }

        /// <summary>
        /// Меод, возвращающий заданное количество минимальных значений среднего балла учеников Student        /// </summary>
        /// <param name="student"></param>
        /// <param name="amountMin"></param>
        /// <returns></returns>
        public static double[] MinMeans(double maxValue, Student[] student, int amountMin)
        {
            double[] minMeans = new double[amountMin];
            minMeans[0] = MinMean(maxValue, student);
            for (int i = 1; i < amountMin; i++)
            {
                minMeans[i] = MinMean(maxValue, student, minMeans[i - 1]);
            }
            return minMeans;
        }

        /// <summary>
        /// Метод преобразования массива в строку
        /// </summary>
        /// <param name="array">массив элементов типа double, который нужно преобразовать в строку</param>
        /// <returns>строка, составленная из элементов массива</returns>
        public static string ToString(double[] array)
        {
            string array_toString = string.Empty;
            for (int i = 0; i < array.Length; ++i)
                array_toString = String.Concat(array_toString, " ",array[i]);
            return array_toString;
        }


        public static string ToString(Student[] array)
        {
            string array_toString = string.Empty;
            for (int i = 0; i < array.Length; ++i)
                array_toString = String.Concat(array_toString, "\n", array[i].surname_Name);
            return array_toString;
        }


        /// <summary>
        /// Метод поиска учеников с наименьшим средник баллом
        /// </summary>
        /// <param name="minMeans">массив минимальных баллов</param>
        /// <param name="student">массив студентов и их средних баллов</param>
        /// <returns>возврщет массив студентов с наименьшими средними баллами</returns>
        public static Student[] FindWorst(double[] minMeans, Student[] student)
        {
            Student[] worstStudents = { };
            int k = 0;
            for (int i = 0; i < minMeans.Length; ++i)
            {
                for (int j = 0; j < student.Length; ++j)
                {
                    if (student[j].mean == minMeans[i])
                    {
                        Array.Resize(ref worstStudents, worstStudents.Length + 1);
                        worstStudents[k].surname_Name = student[j].surname_Name;
                        worstStudents[k].mean = student[j].mean;
                        ++k;
                    }
                }

            }
            return worstStudents;
        }
    }
}
