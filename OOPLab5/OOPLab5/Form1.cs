using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputString = textBox1.Text; // Отримання введеного рядка
            int startPos = Convert.ToInt32(textBox2.Text); // Отримання початкової позиції
            int length = Convert.ToInt32(textBox3.Text); // Отримання довжини підрядка, який потрібно видалити

            string resultString = inputString.Remove(startPos, length); // Видалення підрядка з рядка

            labelResult.Text = resultString; // Виведення результату відформатованого рядка в textBox4
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputString = textBox5.Text; // Отримання введеного рядка
            string searchString = textBox6.Text; // Отримання підрядка, який потрібно знайти

            int firstIndex = -1; // Індекс першого входження підрядка
            int lastIndex = -1; // Індекс останнього входження підрядка

            for (int i = 0; i < inputString.Length - searchString.Length + 1; i++)
            {
                if (inputString.Substring(i, searchString.Length) == searchString)
                {
                    if (firstIndex == -1) // Якщо першого входження ще не було знайдено
                    {
                        firstIndex = i;
                    }
                    lastIndex = i; // Збереження останнього знайденого входження
                }
            }

            if (firstIndex == -1) // Якщо підрядок не знайдено
            {
                lblResult.Text = "Підрядок не знайдено";
            }
            else
            {
                lblResult.Text = "Перше входження: " + firstIndex.ToString() + Environment.NewLine +
                                "Останнє входження: " + lastIndex.ToString();
            }
        }
    }
}

