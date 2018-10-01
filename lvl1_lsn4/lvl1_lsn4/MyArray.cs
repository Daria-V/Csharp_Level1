using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lvl1_lsn4
{
    public class MyArray
    {
        int[] myArray;

        /// <summary>
        /// Конструктор массива заданной длины
        /// </summary>
        /// <param name="l"></param>
        public MyArray(int l)
        {
            myArray = new int[l];
            Random random = new Random();
            for (int i=0; i < l; i++)
            {
                myArray[i] = random.Next();
            }
        }

        /// <summary>
        /// Констрктор одномерного массива заданной длины и заданным шагом
        /// </summary>
        /// <param name="l">Длина массива</param>
        /// <param name="step">шаг</param>
        /// <param name="minVal">минимальное значение первого элемента массива</param>
        /// <param name="maxVal">максимально значение первого элемента массива</param>
        public MyArray(int l, int step, int minVal, int maxVal)
        {
            Random random = new Random();

            myArray = new int[l];
            myArray[0] = random.Next(minVal, maxVal);
            for (int i = 1; i < l; i++)
            {
                myArray[i] = myArray[i - 1] + step;
            }
        }

        /// <summary>
        /// Конструктор массива с длиной l и значениями элементов в диапазоне от minVal до maxVal
        /// </summary>
        /// <param name="l">длина массива</param>
        /// <param name="minVal">минимальное значение элемента массива</param>
        /// <param name="maxVal">максимальное начение элемента массива</param>
        public MyArray (int l, int minVal, int maxVal)
        {
            myArray = new int[l];
            Random random = new Random();
            for (int i = 0; i < l; i++)
            {
                myArray[i] = random.Next(minVal, maxVal);
            }

        }

        /// <summary>
        /// Конструктор массива, значения которого заполняются из файла
        /// </summary>
        /// <param name="path"></param>
        public MyArray(string[] str)
        {
           
            myArray = new int[str.Length];

            for (int i = 0; i < str.Length; i++)
                myArray[i] = int.Parse(str[i]);
        }

        

        /// <summary>
        /// Индексируемое свойство
        /// </summary>
        /// <param name="i">индекс элемента массива</param>
        /// <returns></returns>
        public int this[int i]
        {
            get { return myArray[i]; }
            set { myArray[i] = value; }
        }


        /// <summary>
        /// Метод конвертации всех элементов массива в сроку
        /// </summary>
        /// <returns>возвращает  все элементы массива в виде одной строки</returns>
        public override string  ToString()
        {
            string str = string.Empty;
            foreach (int a in myArray)
            {
                str += $"{a} ";
            }
            return str;

        }

        /// <summary>
        /// Метод записи массива в файл
        /// </summary>
        /// <param name="path">путь к файлу для записи</param>
        public void PutIntoFile(string path)
        {
            string[] str = new string[myArray.Length];
            for (int i = 0; i < myArray.Length; i++)
                str[i] = myArray[i].ToString();
            File.WriteAllLines(path, str);
        }


        /// <summary>
        /// Подсчет пар элементов, из которых хотя бы один кратный заданному числу
        /// </summary>
        public int CountCouples(int denominator)
        {
            int i = 0;
            int countCouples = 0;
            while (i < myArray.Length - 1)
                {
                if (myArray[i] % denominator == 0 || myArray[i + 1] % denominator == 0)  countCouples++ ;
                i++;
                }
            return countCouples;
        }

        /// <summary>
        /// метод умножения элементов массива на заданное число(множитель)
        /// </summary>
        /// <param name="factor">множитель</param>
        /// <returns></returns>
        public MyArray Multi(int factor)
        {
            MyArray temp_myArray = new MyArray(myArray.Length);
            for (int i = 0; i < myArray.Length; i++)
            {
                temp_myArray[i] = myArray[i] * factor; 
            }
            return temp_myArray;
        }

        /// <summary>
        /// Метод замены знака элементов массива на противоположный
        /// </summary>
        /// <returns></returns>
        public MyArray Reverse()
        {
            MyArray temp_myArray = new MyArray(myArray.Length);
            for (int i = 0; i < myArray.Length; i++)
            {
                temp_myArray[i] = - myArray[i];
            }
            return temp_myArray;
        }

        /// <summary>
        /// свойство массива, возвращающее сумму значений его элементов
        /// </summary>
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < myArray.Length; i++)
                    sum += myArray[i];
                return sum;
            }
            
        }
        
    }
}
