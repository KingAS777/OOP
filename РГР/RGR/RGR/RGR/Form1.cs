using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGR
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Admin\Desktop\ООП Андрей\РГР\RGR\RGR\VetBase.mdb";
        public Form1()
        {
            InitializeComponent();
        }

        private void InsertDataButton_Click(object sender, EventArgs e)
        {
            // Отримуємо дані з текстових полів
            string name = nameTextBox.Text;
            string breed = BreedTextBox.Text;
            string ownername = OwnernameTextBox.Text;
            DateTime DateValue = DateDateTimePicker.Value;
            string disease = DiseaseTxtBox.Text;
            string kind = KindTxtBox.Text;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // Запит на вставку даних
                string insertQuery = "INSERT INTO Тварини (Кличка, Порода, Ім_я_власника, Дата_захворювання, Хвороба, Вид) VALUES (?, ?, ?, ?, ?, ?)";

                // Виконуємо команду з параметрами
                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@p1", name);
                    command.Parameters.AddWithValue("@p2", breed);
                    command.Parameters.AddWithValue("@p3", ownername);
                    command.Parameters.AddWithValue("@p4", DateValue.ToString("MM/dd/yyyy"));
                    command.Parameters.AddWithValue("@p5", disease);
                    command.Parameters.AddWithValue("@p6", kind);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Дані успішно вставлені до бази даних.");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchCriteria = searchTextBox.Text;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // Запит на пошук даних за критерієм
                string searchQuery = "SELECT * FROM Тварини WHERE Кличка = ?";

                using (OleDbCommand command = new OleDbCommand(searchQuery, connection))
                {
                    command.Parameters.AddWithValue("@p0", searchCriteria);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        StringBuilder searchResults = new StringBuilder();

                        // Читаємо дані і формуємо результати пошуку
                        while (reader.Read())
                        {
                            string employeeId = reader["Код"].ToString();
                            string employeeName = reader["Кличка"].ToString();
                            string employeeSurname = reader["Порода"].ToString();
                            string employeegroup = reader["Ім_я_власника"].ToString();
                            string employeeDate = reader["Дата_захворювання"].ToString();
                            string employeedisease = reader["Хвороба"].ToString();
                            string employeekind = reader["Вид"].ToString();

                            searchResults.AppendLine($"ID: {employeeId}");
                            searchResults.AppendLine($"Ім'я: {employeeName}");
                            searchResults.AppendLine($"Прізвище: {employeeSurname}");
                            searchResults.AppendLine($"Назва групи {employeegroup}");
                            searchResults.AppendLine($"Дата захворювання: {employeeDate}");
                            searchResults.AppendLine($"Хвороба {employeedisease}");
                            searchResults.AppendLine($"Вид {employeekind}");
                            searchResults.AppendLine();
                        }

                        // Виводимо результати пошуку у RichTextBox
                        searchResultsRichTextBox.Text = searchResults.ToString();
                    }
                }
            }
        }

        private void DisplayDataButton_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // Отримуємо дані з бази даних
                DataTable dataTable = RetrieveData(connection);

                // Відображаємо дані в DataGridView
                dataGridView.DataSource = dataTable;
            }
        }
        private DataTable RetrieveData(OleDbConnection connection)
        {
            // Запит на отримання даних
            string selectQuery = "SELECT * FROM Тварини";

            using (OleDbDataAdapter adapter = new OleDbDataAdapter(selectQuery, connection))
            {
                // Створюємо нову таблицю
                DataTable dataTable = new DataTable();

                // Заповнюємо таблицю даними з бази даних
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // Звіт 1: Загальна інформація про співробітників
                string reportQuery1 = "SELECT * FROM Тварини";

                using (OleDbCommand command = new OleDbCommand(reportQuery1, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        StringBuilder report1 = new StringBuilder();

                        // Читаємо дані і формуємо звіт
                        while (reader.Read())
                        {
                            string employeeId = reader["Код"].ToString();
                            string employeeName = reader["Кличка"].ToString();
                            string employeeSurname = reader["Порода"].ToString();
                            string employeegroup = reader["Ім_я_власника"].ToString();
                            string employeeDate = reader["Дата_захворювання"].ToString();
                            string employeedisease = reader["Хвороба"].ToString();
                            string employeekind = reader["Вид"].ToString();

                            report1.AppendLine($"ID: {employeeId}");
                            report1.AppendLine($"Ім'я: {employeeName}");
                            report1.AppendLine($"Прізвище: {employeeSurname}");
                            report1.AppendLine($"Ім'я власника: {employeegroup}");
                            report1.AppendLine($"Дата народження: {employeeDate}");
                            report1.AppendLine($"Хвороба: {employeedisease}");
                            report1.AppendLine($"Вид: {employeekind}");
                            report1.AppendLine();
                        }

                        // Виводимо звіт 1 у RichTextBox
                        reportRichTextBox.Text = report1.ToString();
                    }

                }

                // Звіт 2: Звіт за критерієм вибору (наприклад, посада)
                string reportQuery2 = "SELECT * FROM Тварини WHERE Вид = ?";

                using (OleDbCommand command = new OleDbCommand(reportQuery2, connection))
                {
                    command.Parameters.AddWithValue("@p0", "Собака"); // Замініть на вибраний критерій

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        StringBuilder report2 = new StringBuilder();

                        // Читаємо дані і формуємо звіт
                        while (reader.Read())
                        {
                            string employeeId = reader["Код"].ToString();
                            string employeeName = reader["Кличка"].ToString();
                            string employeeSurname = reader["Порода"].ToString();
                            string employeegroup = reader["Ім_я_власника"].ToString();
                            string employeeDate = reader["Дата_захворювання"].ToString();
                            string employeedisease = reader["Хвороба"].ToString();
                            string employeekind = reader["Вид"].ToString();

                            report2.AppendLine($"ID: {employeeId}");
                            report2.AppendLine($"Ім'я: {employeeName}");
                            report2.AppendLine($"Прізвище: {employeeSurname}");
                            report2.AppendLine($"Ім'я власника: {employeegroup}");
                            report2.AppendLine($"Дата народження: {employeeDate}");
                            report2.AppendLine($"Хвороба: {employeedisease}");
                            report2.AppendLine($"Вид: {employeekind}");
                            report2.AppendLine();
                        }

                        // Виводимо звіт 2 у RichTextBox
                        reportRichTextBox2.Text = report2.ToString();
                    }
                }
            }
        }
    }
}

