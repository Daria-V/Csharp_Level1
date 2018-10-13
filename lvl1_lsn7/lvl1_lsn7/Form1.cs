using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lvl1_lsn7
{
    public partial class Form1 : Form
    {
        int i = 0;
        static Stack<byte> clickStack = new Stack<byte>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            clickStack.Push(2);
            counter.Text = (++i).ToString();
            checkResult(lblTarget.Text, lblNumber.Text);
            

        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {

            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            clickStack.Push(1);
            counter.Text = (++i).ToString();
            checkResult(lblTarget.Text,lblNumber.Text);
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            counter.Text = "0";
            i = 0;
            clickStack.Clear();
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Начало игры. Сброс всех предыдущих значений. Установка новой цели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnReset_Click(btnReset, e);
            Random targetRandom = new Random();
            lblTarget.Text = (targetRandom.Next(1,10)).ToString();
            MessageBox.Show("Вам необходимо получить число " + lblTarget.Text);
            btnCommand1.Enabled = true;
            btnCommand2.Enabled = true;
            btnReset.Enabled = true;
            unDo.Enabled = true;
        }

        /// <summary>
        /// Проверка текущего значения на равенство целевому
        /// </summary>
        /// <param name="target"></param>
        /// <param name="currentValue"></param>
        /// <returns></returns>
        static bool checkResult(string target, string currentValue)
        {
            if (target == currentValue)
            {
                MessageBox.Show("Цель достигнута!");
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Отмена хода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void unDo_Click(object sender, EventArgs e)
        {
            if (clickStack.Count != 0)
            {
                if (clickStack.Pop() == 1) undo_btnCommand1_Click();
                else undo_btnCommand2_Click();
            }
            else
            {
                MessageBox.Show("Стек пуст. Начинаем играть заново!");              
            }
        }

        /// <summary>
        /// Отмена прибавления единицы
        /// </summary>
        private void undo_btnCommand1_Click()
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) - 1).ToString();
            counter.Text = (--i).ToString();
        }

        /// <summary>
        /// Отмена умножения на 2
        /// </summary>
         void undo_btnCommand2_Click()
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) / 2).ToString();
            counter.Text = (--i).ToString();
        }

       public string StackToString(Stack<byte> clickStack)
        {
            string stackString = string.Empty;
            foreach (byte s in clickStack)
             stackString += s.ToString() + " ";
            return stackString;
        }
      
        
    }
}
