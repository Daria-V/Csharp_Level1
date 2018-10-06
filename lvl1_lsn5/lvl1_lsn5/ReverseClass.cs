using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lvl1_lsn5
{
    public class ReverseClass
    {
        /// <summary>
        /// метод, "переворачивающий" строку, используя средства C#
        /// </summary>
        /// <param name="str1">строка, которую нужно "перевернуть"</param>
        /// <returns>"перевернутая" строка</returns>
        public static string ReverseString(string str1)
        {
            char[] str1_array = str1.ToCharArray();
            Array.Reverse(str1_array);
            string str1_reverse = new string(str1_array);
            return str1_reverse;
        }

        /// <summary>
        /// метод, "переврачивающий" строку, перебирая все элементы строки
        /// </summary>
        /// <param name="str1">строка, которую нужно "перевернуть"</param>
        /// <returns>"перевернутая" строка</returns>
        public static string ReverseStringMy(string str1)
        {
            string str1_reverse = string.Empty;
             for (int i = str1.Length - 1; i >= 0; i--)
                 str1_reverse += str1[i];
            return str1_reverse;
        }
    }
}
