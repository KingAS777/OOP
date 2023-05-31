using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Зчитування масиву з користувача
            string input = txtInput.Text;
            string[] values = input.Split(' ');
            double[] array = new double[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                array[i] = Convert.ToDouble(values[i]);
            }

            // Розрахунок сум елементів масиву
            double sumOdd = 0;
            double sumBetweenNegatives = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sumOdd += array[i];
                }
                if (array[i] < 0)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] < 0)
                        {
                            break;
                        }
                        sumBetweenNegatives += array[j];
                    }
                    break;
                }
            }

            // Стискання масиву
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) > 1)
                {
                    array[count] = array[i];
                    count++;
                }
            }
            for (int i = count; i < array.Length; i++)
            {
                array[i] = 0;
            }

            // Вивід результатів за допомогою MessageBox
            string output = "Сума елементів масиву з непарними номерами: " + sumOdd + Environment.NewLine;
            output += "Сума елементів масиву, розташованих між першим і останнім від’ємними елементами: " + sumBetweenNegatives + Environment.NewLine;
            output += "Стиснутий масив: " + string.Join(" ", array);
            MessageBox.Show(output, "Результати розрахунків");
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {

                // Зчитування двовимірного масиву з користувача
                string input = txtInput2.Text;
                string[] rows = input.Split(';');
                double[,] array = new double[rows.Length, rows.Length];
                for (int i = 0; i < rows.Length; i++)
                {
                    string[] values = rows[i].Split(' ');
                    for (int j = 0; j < values.Length; j++)
                    {
                        array[i, j] = Convert.ToDouble(values[j]);
                    }
                }

                // Порівняння елементів масиву
                double upperRight = array[0, array.GetLength(1) - 1];
                double minElement = array[0, 0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    // Порівнюємо елемент з верхнім правим
                    if (i == 0 && j == array.GetLength(1) - 1)
                    {
                        double absUpperRight = Math.Abs(upperRight);
                        double absElement = Math.Abs(array[i, j]);
                        string message = absUpperRight > absElement ? "Верхній правий елемент більший за інший" : "Інший елемент більший за верхній правий";
                        MessageBox.Show(message);
                    }
                    // Порівнюємо два елементи
                    if (i == 0 && j == 0)
                    {
                        minElement = array[i, j];
                    }
                    else
                    {
                        double absMinElement = Math.Abs(minElement);
                        double absElement = Math.Abs(array[i, j]);
                        if (absElement < absMinElement)
                        {
                            minElement = array[i, j];
                        }
                    }
                }
            }

            // Виведення результату порівняння двох елементів масиву
            string minElementMessage = "Найменший елемент масиву: " + minElement;
            MessageBox.Show(minElementMessage);
        }
    }
}


