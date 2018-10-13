using System.Windows.Forms;
using System;

namespace lvl1_lsn7
{
    internal class Form2 : Form
    {
        
        private Label lblTryCount;
        private Label lblRestTry;
        private Label lblRestTryCount;
        private TextBox InputValue;
        private Label label2;
        private Label label1;
        private Label lblNumber;
        private Button newGame;
        private Label tryLimit;

        public Form2(int number)
        {
            InitializeComponent(number);
        }
        public Form2()
        {
            InitializeComponent();
            lblRestTryCount.Text = lblTryCount.Text;
        }

        private void InitializeComponent(int number)
        {
            //int num = number;
            
            InitializeComponent();
            this.lblNumber.Text = number.ToString();
            lblRestTryCount.Text = lblTryCount.Text;
        }

        private void InitializeComponent()
        {
            this.lblTryCount = new System.Windows.Forms.Label();
            this.tryLimit = new System.Windows.Forms.Label();
            this.lblRestTry = new System.Windows.Forms.Label();
            this.lblRestTryCount = new System.Windows.Forms.Label();
            this.InputValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.newGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTryCount
            // 
            this.lblTryCount.AutoSize = true;
            this.lblTryCount.Location = new System.Drawing.Point(170, 4);
            this.lblTryCount.Name = "lblTryCount";
            this.lblTryCount.Size = new System.Drawing.Size(13, 13);
            this.lblTryCount.TabIndex = 0;
            this.lblTryCount.Text = "5";
            // 
            // tryLimit
            // 
            this.tryLimit.AutoSize = true;
            this.tryLimit.Location = new System.Drawing.Point(13, 3);
            this.tryLimit.Name = "tryLimit";
            this.tryLimit.Size = new System.Drawing.Size(115, 13);
            this.tryLimit.TabIndex = 1;
            this.tryLimit.Text = "Количество попыток:";
            // 
            // lblRestTry
            // 
            this.lblRestTry.AutoSize = true;
            this.lblRestTry.Location = new System.Drawing.Point(16, 46);
            this.lblRestTry.Name = "lblRestTry";
            this.lblRestTry.Size = new System.Drawing.Size(105, 13);
            this.lblRestTry.TabIndex = 2;
            this.lblRestTry.Text = "Осталось попыток:";
            // 
            // lblRestTryCount
            // 
            this.lblRestTryCount.AutoSize = true;
            this.lblRestTryCount.Location = new System.Drawing.Point(170, 46);
            this.lblRestTryCount.Name = "lblRestTryCount";
            this.lblRestTryCount.Size = new System.Drawing.Size(13, 13);
            this.lblRestTryCount.TabIndex = 3;
            this.lblRestTryCount.Text = this.lblTryCount.Text;
            // 
            // InputValue
            // 
            this.InputValue.Location = new System.Drawing.Point(19, 119);
            this.InputValue.Name = "InputValue";
            this.InputValue.Size = new System.Drawing.Size(100, 20);
            this.InputValue.TabIndex = 4;
            this.InputValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputValue_KeyDown);
            this.InputValue.Enabled = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите число от 1 до 100 и нажмите Enter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Загаданное число:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(132, 236);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(13, 13);
            this.lblNumber.TabIndex = 7;
            this.lblNumber.Text = "0";
            // 
            // newGame
            // 
            this.newGame.Location = new System.Drawing.Point(187, 206);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(85, 42);
            this.newGame.TabIndex = 8;
            this.newGame.Text = "Загадать новое";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputValue);
            this.Controls.Add(this.lblRestTryCount);
            this.Controls.Add(this.lblRestTry);
            this.Controls.Add(this.tryLimit);
            this.Controls.Add(this.lblTryCount);
            this.Name = "Form2";
            this.Text = "Угадай число";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        private void textBox_TextChanged(object sender, System.EventArgs e)
        {
            if (InputValue.Text == lblNumber.Text) MessageBox.Show("Вы угадали!");
            else
            {
                { 
                    lblRestTryCount.Text = (int.Parse(this.lblRestTryCount.Text) - 1).ToString();
                    InputValue.Text = "";
                }

                if (lblRestTryCount.Text == "0")
                {
                    MessageBox.Show("Увы, вы исчерпали все попытки");
                    InputValue.Enabled = false;
                    InputValue.Text = "";
                }
            }

        }

        private void InputValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox_TextChanged(sender, e);
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {

        }

        private void newGame_Click(object sender, System.EventArgs e)
        {
            Random r = new Random();
            int number = r.Next(1, 100);
            this.lblNumber.Text = number.ToString();
            lblRestTryCount.Text = lblTryCount.Text;
            InputValue.Text = "";
        }
    }
}