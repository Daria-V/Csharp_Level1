using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lvl1_lsn3
{
    class ComplexClass
    {
        public double im;
        public double re;

        /// <summary>
        /// Конструктор комплексного числа по умолчанию. Task1
        /// </summary>
        public ComplexClass()
        {
            im = re = 0;
        }
        /// <summary>
        /// Конструктор комплексного числа с двумя входными параметрами(действительная часть, коэффициент мнимой части) Task1
        /// </summary>
        /// <param name="_re">действительная часть(double)</param>
        /// <param name="_im">коэффициент мнимой части(double)</param>
        public ComplexClass(double _re, double _im)
        {
            this.re = _re;
            this.im = _im;
        }

        /// <summary>
        /// Метод вычитания комплексных чисел
        /// </summary>
        /// <param name="x2">комплексное число, которое необходимо отняьт от текущего</param>
        /// <returns></returns>
        public ComplexClass Minus (ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = this.im - x2.im;
            x3.re = this.re - x2.re;
            return x3;
        }
/// <summary>
/// Метод перемножения комплексных чисел
/// </summary>
/// <param name="x2"></param>
/// <returns></returns>
        public ComplexClass Multiply(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = this.re * x2.im + this.im * x2.re;
            x3.re = this.re * x2.re - this.im * x2.im;
            return x3;
        }

        public string ToString()
        {
            return $"{re} + ({im})i";
        }

    }
}
