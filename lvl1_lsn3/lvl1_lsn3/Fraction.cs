using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lvl1_lsn3
{/// <summary>
/// Класс дробей. Task3
/// </summary>
    class Fraction
    {
         public  int numerator;
         public  int denominator;
         public double quotient;
        // public string quotientString;

/// <summary>
/// Конструктор по умолчанию
/// </summary>
        public Fraction()
        {
            numerator = denominator = 0;
            // quotient = numerator/denominator;
            quotient = 0;
          //  quotientString = "";

        }
       /// <summary>
       /// Констрактор объекта класса Fraction с двумя входными параметрами(числитель, знаменатель)
       /// </summary>
       /// <param name="num">числитель(int)</param>
       /// <param name="denom">знаменатель(int)</param>
        public Fraction (int num, int denom)
        {
            numerator = num;
            denominator = denom;
            quotient = Convert.ToDouble(numerator) / denominator;
           // quotientString = $"{numerator} / {denominator}";
        }

        /// <summary>
        /// Метод сложения дробей. Task3
        /// </summary>
        /// <param name="q2">Дробь, которую нужно прибавить к текущей</param>
        /// <returns>Возвращает результат сложения дробей</returns>
        public Fraction Plus(Fraction q2)
        {
            Fraction q3 = new Fraction();
            if (this.denominator == q2.denominator)
            {
                q3.numerator = this.numerator + q2.numerator;
                q3.denominator = this.denominator;
                q3.quotient = Convert.ToDouble(q3.numerator) / q3.denominator;
               // q3.quotientString = $"{q3.numerator} / {q3.denominator}";
                return q3;
            }
            else
            {
                q3.numerator = (this.numerator * q2.denominator) + (q2.numerator * this.denominator);
                q3.denominator = this.denominator * q2.denominator;
                q3.quotient = Convert.ToDouble(q3.numerator) / q3.denominator;
                //q3.quotientString = $"{q3.numerator} / {q3.denominator}";
                return q3;
            }
        }

        /// <summary>
        /// Метод вычитания дробей. Task3
        /// </summary>
        /// <param name="q2">Дробь, которую нужно отнять от текущей</param>
        /// <returns>Возвращает результат вычитания дробей</returns>
        public Fraction Minus(Fraction q2)
        {
            Fraction q3 = new Fraction();
            if (this.denominator == q2.denominator)
            {
                q3.numerator = this.numerator - q2.numerator;
                q3.denominator = this.denominator;
                q3.quotient = Convert.ToDouble(q3.numerator) / q3.denominator;
                
                return q3;
            }
            else
            {
                q3.numerator = (this.numerator * q2.denominator) - (q2.numerator * this.denominator);
                q3.denominator = this.denominator * q2.denominator;
                q3.quotient = Convert.ToDouble(q3.numerator) / q3.denominator;
                
                return q3;
            }
        }

        /// <summary>
        /// Метод умножения дробей. Task3
        /// </summary>
        /// <param name="q2">Дробь, которую нужно перемножить с текущей</param>
        /// <returns>Возвращает результат умножения дробей</returns>
        public Fraction Multiply(Fraction q2)
        {
            Fraction q3 = new Fraction();
            q3.numerator = this.numerator * q2.numerator;
            q3.denominator = this.denominator * q2.denominator;
            q3.quotient = Convert.ToDouble(q3.numerator) / q3.denominator;

            return q3;
        }

        /// <summary>
        /// Метод деления дробей. Task3
        /// </summary>
        /// <param name="q2">Дробь, на которую нужно разделить текущую</param>
        /// <returns>Возвращает результат деления двух дробей</returns>
        public Fraction Divide(Fraction q2)
        {
            Fraction q3 = new Fraction();
            q3.numerator = this.numerator * q2.denominator;
            q3.denominator = this.denominator * q2.numerator;
            q3.quotient = Convert.ToDouble(q3.numerator) / q3.denominator;

            return q3;
        }

        //public Fraction Reverse(Fraction q)
        //{
        //    int temp = q.numerator;

        //    numerator = q.denominator;
        //    denominator = temp;
        //}

        public string ToString()
        {
            return $"{numerator} / {denominator}";
        }

    
    }
}
