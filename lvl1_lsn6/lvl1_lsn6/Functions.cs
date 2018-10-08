using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lvl1_lsn6
{ /// <summary>
/// Task1
/// </summary>
    public class Functions
        {/// <summary>
         /// Функция а*х*х
         /// </summary>
         /// <param name="a">коэффициент</param>
         /// <param name="x">возводимое в квадрат число</param>
         /// <returns>возвращает результат вычисления а*х*х </returns>
        public static double Function1(double a, double x)
        {
            return a * Math.Pow(x, 2);
        }

        /// <summary>
        /// Функция a* sin(x)
        /// </summary>
        /// <param name="a">коэффициент</param>
        /// <param name="x">угол</param>
        /// <returns>возвращает результат вычисления a*sin(x)</returns>
        public static double Function2(double a, double x)
        {
            return a * Math.Sin(x);
        }

        /// <summary>
        /// Таблица функций
        /// </summary>
        /// <param name="F">Функция</param>
        /// <param name="a">коэффициент</param>
        /// <param name="x">параметр функции(угол)</param>
        /// <param name="x1">граница изменения и вывода прметра функции(угла)</param>
        public static void Table(DelegateForTable F, double a, double x, double x1)
        {
            Console.WriteLine($"----- X ----- Y -----   Параметр a = {a}");
            while (x <= x1)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a, x));
                x += 10;
            }
        }
    }
}
