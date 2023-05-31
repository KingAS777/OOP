using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримання значень параметрів з текстових полів
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);
                double x1 = double.Parse(txtX1.Text);
                double y1 = double.Parse(txtY1.Text);

                // Обчислення відстані за формулою
                double distance = Math.Abs(a * x1 + b * y1 + c) / Math.Sqrt(a * a + b * b);

                // Виведення результату
                lblResult.Text = $"Відстань від точки до прямої: {distance:F2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення параметрів і координат точки.",
                    "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
