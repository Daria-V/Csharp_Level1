using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lvl1_lsn6
{

    /// <summary>
    /// Класс Студент. Задание 3
    /// </summary>
    public class Student
    {
        public string firstName;
        public string lastName;
        public string university;
        public string faculty;
        public string department;
        public int course;
        public int group;
        public int age;
        public string city;

        /// <summary>
        /// Конструктор Студент
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <param name="lastName">Фамилия</param>
        /// <param name="university">ВУЗ</param>
        /// <param name="faculty">факультет</param>
        /// <param name="department">кафедра</param>
        /// <param name="age">возраст</param>
        /// <param name="course">курс</param>
        /// <param name="group">группа</param>
        /// <param name="city">город</param>
        public Student(string firstName,string lastName,string university,string faculty,string department, int age, int course,int group,string city)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.group = group;
            this.age = age;
            this.city = city;
        }

        /// <summary>
        /// метод преобразования Student в string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format($"{firstName}, {lastName}, {university}, {faculty}, возраст {age}, курс {course}");
        }


        /// <summary>
        /// предикат. 
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public static bool FoundMagistr(Student student)
        {
            if (student.course == 5 | student.course == 6) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
