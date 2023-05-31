using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private SortArray sortArray;
        private XorArray xorArray;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSortArray_Click(object sender, EventArgs e)
        {
            // Перевірка наявності даних в полях введення
            if (string.IsNullOrWhiteSpace(txtSortArray1.Text) || string.IsNullOrWhiteSpace(txtSortArray2.Text))
            {
                MessageBox.Show("Будь ласка, заповніть поля зі значеннями масивів.");
                return;
            }

            // Розділення рядка на числові значення
            var array1 = txtSortArray1.Text.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                          .Select(int.Parse);
            var array2 = txtSortArray2.Text.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                          .Select(int.Parse);

            // Створення інстансів класів SortArray
            this.sortArray = new SortArray(array1);
            var sortArray2 = new SortArray(array2);

            // Об'єднання масивів і виклик методу ForEach для виведення результату
            var resultArray = (SortArray)this.sortArray.Add(sortArray2);
            if (resultArray != null)
            {
                lstSortArray.Items.Clear();
                resultArray.ForEach(item => lstSortArray.Items.Add(item));
            }
        }

        private void btnXorArray_Click(object sender, EventArgs e)
        {
            // Перевірка наявності даних в полі введення
            if (string.IsNullOrWhiteSpace(txtXorArray.Text))
            {
                MessageBox.Show("Будь ласка, заповніть поле зі значеннями масиву.");
                return;
            }

            // Розділення рядка на числові значення
            var array = txtXorArray.Text.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse);

            // Створення інстансу класу XorArray
            this.xorArray = new XorArray(array);

            // Обчислення кореня кожного елемента масиву та виклик методу ForEach для виведення результату
            lstXorArray.Items.Clear();
            this.xorArray.ForEach(item => lstXorArray.Items.Add(item));
        }
    }

}
