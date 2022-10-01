using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverloadingOperators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearAllTextbox()
        {
            tbplus.Clear();
            tbequals.Clear();
            tbnonequals.Clear();
            richTextBox1.Clear();
        }
        private void startbtn_Click(object sender, EventArgs e)
            
        {
            clearAllTextbox();
            //проверка на исключения(не менее трех исключений), проверка на ввод в текстбоксы

            try
                
            {
                if (tbstringchar.Text == "" || tbaddedstring.Text == "")
                {
                    throw new Exception("Введите данные в текстбоксы");
                }
                if (tbstringchar.Text.Length < 3 || tbaddedstring.Text.Length < 3)
                {
                    throw new Exception("Введите данные в текстбоксы не менее 3 символов");
                }
                if (tbstringchar.Text.Length > 10 || tbaddedstring.Text.Length > 10)
                {
                    throw new Exception("Введите данные в текстбоксы не более 10 символов");
                }
                charArrayString str1 = new charArrayString(tbstringchar.Text);
                charArrayString str2 = new charArrayString(tbaddedstring.Text);
                charArrayString str3 = str1 + str2;
                tbplus.Text = new string(str3.CharArray);
                //вывести текст в richTextBox1 строку разбитую на символы в ковычках каждый символ

                for (int i = 0; i < str3.CharArray.Length; i++)
                {
                    richTextBox1.Text += "'" + str3.CharArray[i] + "'" + " ";
                }
                if (str1 == str2)
                {
                    tbequals.Text = "True";
                }
                else
                {
                    tbequals.Text = "False";
                }
                if (str1 != str2)
                {
                    tbnonequals.Text = "True";
                }
                else
                {
                    tbnonequals.Text = "False";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                clearAllTextbox();
            }


        }

        private void helpbtn_Click(object sender, EventArgs e)
        {
            //кнопка помощь , выводит сообщение с описанием работы программ

            MessageBox.Show("В текстбоксе 'Первая строка' введите строку не менее 3 символов и не более 10 символов" + Environment.NewLine +
                "В текстбоксе 'Вторая строка' введите строку не менее 3 символов и не более 10 символов" + Environment.NewLine +
                "Нажмите кнопку 'Начать'" + Environment.NewLine +
                "В текстбоксе 'Первая строка + Вторая строка' будет выведена строка полученная из конкатенации строк" + Environment.NewLine +
                "В текстбоксе 'Первая строка == Вторая строка' будет выведено значение True или False в зависимости от того равны ли строки" + Environment.NewLine +
                "В текстбоксе 'Первая строка != Вторая строка' будет выведено значение True или False в зависимости от того не равны ли строки" + Environment.NewLine +
                "В текстбоксе 'Вывод строки' будет выведена строка полученная из конкатенации строк разбитая на символы в ковычках каждый символ" + Environment.NewLine +
                "Нажмите кнопку 'Очистить' для очистки всех текстбоксов");
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearAllTextbox();
        }

        private void closetbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void genbtn_Click(object sender, EventArgs e)
        {
            //generate random 10 symbols string

            Random rnd = new Random();

            string str = "";
            string str2 = "";

            for (int i = 0; i < 10; i++)
            {
                str += (char)rnd.Next(1, 255);
                str2 += (char)rnd.Next(1, 255);
            }
            tbstringchar.Text = str;
            tbaddedstring.Text = str2;
            
        }
    }
}
