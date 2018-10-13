using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// ДЗ. Уровень 1. Урок 7. Выполнила Свидлова Д.
/// </summary>
namespace lvl1_lsn7
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Task1
            //а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
            //б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
            //в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный класс Stack.
            //Вся логика игры должна быть реализована в классе с удвоителем.

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            #endregion

            #region Task2
            //2.Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, 
            //а человек пытается его угадать за минимальное число попыток.Для ввода данных от человека используется элемент TextBox.

            Random r = new Random();
            int numberToDivine = r.Next(1, 100);
            Application.Run(new Form2(numberToDivine));





            #endregion
        }
    }
}
