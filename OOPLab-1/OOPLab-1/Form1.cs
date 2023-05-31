using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages[0].Text = "1.1";
            tabControl1.TabPages[1].Text = "1.2";
            tabControl1.TabPages[2].Text = "1.3";
            tabControl1.TabPages[3].Text = "1.4";
            tabControl1.TabPages[4].Text = "1.5";
            tabControl1.TabPages[5].Text = "1.6";
            tabControl1.TabPages[6].Text = "1.7";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBoxX.Text); // присвоєння зміної х до числа з textBoxX 
            double y = Convert.ToDouble(textBoxY.Text); // присвоєння зміної у до числа з textBoxY
            double result = (Math.Exp(x) - Math.Pow(y, 2) + 12 * x * y - 3 * Math.Pow(x, 2)) / (18 * y - 1); // розв'язання (e^x - y^2 + 12xy - 3x^2) / (18y - 1)
            label1.Text = result.ToString();
        }

        private void textBoxX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBoxX.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button1.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void textBoxY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBoxY.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button1.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtX.Text);
            double y = double.Parse(txtY.Text);
            double sum = x + y;
            txtResult.Text = sum.ToString();
        }

        private void btnDiff_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtX.Text);
            double y = double.Parse(txtY.Text);
            double diff = x - y;
            txtResult.Text = diff.ToString();
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtX.Text);
            double y = double.Parse(txtY.Text);
            double prod = x * y;
            txtResult.Text = prod.ToString();
        }

        private void btnQuot_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtX.Text);
            double y = double.Parse(txtY.Text);
            double quot = x / y;
            txtResult.Text = quot.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtBoxN.Text); // зчитуємо тризначне число з текстового поля
            int firstDigit = n / 100; // знаходимо першу цифру числа
            int secondDigit = (n / 10) % 10; // знаходимо другу цифру числа
            int thirdDigit = n % 10; // знаходимо третю цифру числа

            bool isGeometricProgression = false; // змінна, що вказуватиме на те, чи є дане число членом геометричної прогресії

            // перевіряємо, чи є числа членами геометричної прогресії
            if (secondDigit * secondDigit == firstDigit * thirdDigit)
            {
                isGeometricProgression = true;
            }

            // виводимо результат
            if (isGeometricProgression)
            {
                labelResult3.Text = "true";
            }
            else
            {
                labelResult3.Text = "false";
            }
        }

        private void buttonResult4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            double c = Convert.ToDouble(textBoxC.Text);

            if (a >= b && b >= c)
            {
                a *= 2;
                b *= 2;
                c *= 2;
            }
            else
            {
                a = Math.Abs(a);
                b = Math.Abs(b);
                c = Math.Abs(c);
            }

            textBoxA1.Text = a.ToString();
            textBoxB1.Text = b.ToString();
            textBoxC1.Text = c.ToString();
        }

        private void buttonResult5_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBoxN2.Text); // зчитуємо вхідне число з текстового поля

            int result = 0; // змінна для збереження результату

            int position = 1; // змінна для збереження поточної позиції цифри

            while (n > 0) // поки число не дійде до кінця
            {
                int digit = n % 10; // отримуємо поточну цифру числа

                if (digit != 1) // якщо цифра не є одиницею
                {
                    result += digit * position; // додаємо цифру до результату зі збереженням порядку
                    position *= 10; // збільшуємо поточну позицію
                }

                n /= 10; // переходимо до наступної цифри
            }

            labelResult5.Text = result.ToString(); // виводимо результат на екран
        }

        private void buttonResult6_Click(object sender, EventArgs e)
        {
            // Отримання рядка введених користувачем чисел
            string input = textBoxAn.Text;

            // Розділення рядка на масив чисел
            string[] numbers = input.Split(' ');

            // Створення списку для зберігання чисел, які є квадратами
            List<int> squares = new List<int>();

            // Проходження по кожному числу та перевірка, чи воно є квадратом
            foreach (string number in numbers)
            {
                int n = int.Parse(number);

                // Перевірка, чи є корінь з числа цілим числом
                if (Math.Sqrt(n) % 1 == 0)
                {
                    squares.Add(n);
                }
            }

            // Виведення результату
            if (squares.Count > 0)
            {
                MessageBox.Show($"Числа, які є квадратами: {string.Join(", ", squares)}");
            }
            else
            {
                MessageBox.Show("Немає чисел, які є квадратами.");
            }
        }

        private void buttonResult7_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text; // отримуємо введений рядок з TextBox
            string output = input.Replace(" ", ", "); // замінюємо всі пробіли на кому та пробіл
            labelResult7.Text = output; // встановлюємо результат у другий TextBox
        }
    }
}

