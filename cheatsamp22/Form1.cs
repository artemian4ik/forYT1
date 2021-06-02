using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cheatsamp22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.TextLength != 0 && textBox2.TextLength != 0 && comboBox1.Text.Length != 0)
                MessageBox.Show("На ваш аккаунт: " + textBox1.Text + "\nВ течение двух часов будет зачислена сумма: " + comboBox1.Text +"$", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Вы не заполнили одно из полей!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
