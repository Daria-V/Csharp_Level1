using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lvl1_lsn6
{
    /// <summary>
    /// Сравнение курсов. Task3
    /// </summary>
    public class CourseComparer : IComparer<Student>
    {     
            public int Compare(Student st1, Student st2)
            {
                if (st1.course > st2.course)
                    return 1;
                else if (st1.course < st2.course)
                    return -1;
                else return 0;
            }
        
    }
}
