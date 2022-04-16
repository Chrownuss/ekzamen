using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kononovRA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Не указано имя!");
            }
            else if (textBox1.Text.Length < 3)
            {
                errorProvider1.SetError(textBox1, "Слишком короткое имя!");
            }
            else if (textBox1.Text.Length > 15)
            {
                errorProvider1.SetError(textBox1, "Слишком длинное имя!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Не указана фамилия!");
            }
            else if (textBox2.Text.Length < 2)
            {
                errorProvider1.SetError(textBox2, "Слишком короткая фамилия!");
            }
            else if (textBox2.Text.Length > 25)
            {
                errorProvider1.SetError(textBox2, "Слишком длинная фамилия!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (String.IsNullOrEmpty(maskedTextBox1.Text))
            {
                errorProvider1.SetError(maskedTextBox1, "Введите телефон!");
            }
            else if (maskedTextBox1.Text.Length < 16)
            {
                errorProvider1.SetError(maskedTextBox1, "Телефон не введён полностью!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
