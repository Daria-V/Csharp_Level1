using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lvl1_lsn6
{/// <summary>
/// Сравнение возраста студентов. Task3
/// </summary>
    public class AgeComparer : IComparer<Student>
    {
        public int Compare(Student st1, Student st2)
        {
            if (st1.age > st2.age)
                return 1;
            else if (st1.age < st2.age)
                return -1;
            else return 0;
        }
    }
}
