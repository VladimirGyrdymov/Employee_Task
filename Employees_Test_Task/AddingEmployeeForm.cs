using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Threading;

namespace Employees_Test_Task
{
    public partial class AddingEmployeeForm : Form
    {
        public AddingEmployeeForm()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source = ВЛАДИМИР-ПК\SQLEXPRESS; Initial Catalog = base; Trusted_Connection = True";
        const int ID_LOCATION_IN_STRING = 2, ID_CORRECTION = 1;
        bool check = true, activation = true;

        private void AddingEmployeeForm_Load(object sender, EventArgs e)
        {
            sexComboBox.Items.Add(Employee.Sex.Мужской);
            sexComboBox.Items.Add(Employee.Sex.Женский);
            sexComboBox.Items.Add(Employee.Sex.Другое);
            sexComboBox.SelectedIndex = 0;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT ID, DepartmentName FROM departments";

            empComboBox.Items.Clear();

            SqlDataReader reader = cmd.ExecuteReader();

            string tmp;

            while (reader.Read())
            {
                tmp = "ID - " + reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString();
                empComboBox.Items.Add(tmp);
            }

            reader.Close();

            empComboBox.SelectedIndex = 0;

            conn.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (yearTextBox.Text == "" || Convert.ToInt32(yearTextBox.Text) > 2010 || Convert.ToInt32(yearTextBox.Text) < 1900 || monthTextBox.Text == "" || Convert.ToInt32(monthTextBox.Text) > 12 || Convert.ToInt32(monthTextBox.Text) < 1 || dayTextBox.Text == "" || Convert.ToInt32(dayTextBox.Text) > 31 || Convert.ToInt32(dayTextBox.Text) < 1)
            {
                activation = false;
                alertTextBox.Text = "Не все поля заполнены / корректны";
                alertTextBox.Visible = true;
            }
            else
            {
                activation = true;
            }

            if (activation == true)
            {
                Employee emp = new Employee();
                try
                {
                    emp.Birthday = new DateTime(Convert.ToInt32(yearTextBox.Text), Convert.ToInt32(monthTextBox.Text), Convert.ToInt32(dayTextBox.Text));
                }
                catch
                {
                    alertTextBox.Text = "Не все поля заполнены";
                    alertTextBox.Visible = true;
                }

                SqlConnection conn = new SqlConnection(connectionString);

                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT LName, FName, MName, Birthday FROM employees";

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (lastNameTextBox.Text == reader.GetValue(0).ToString() && firstNameTextBox.Text == reader.GetValue(1).ToString() && secondNameTextBox.Text == reader.GetValue(2).ToString() && emp.Birthday.ToString() == reader.GetValue(3).ToString())
                    {
                        check = false;
                        alertTextBox.Text = "Такой сотрудник существует";
                        alertTextBox.Visible = true;
                        break;
                    }
                }

                reader.Close();

                if (lastNameTextBox.Text != "" && firstNameTextBox.Text != "" && secondNameTextBox.Text != "" && yearTextBox.Text != "" && monthTextBox.Text != "" && dayTextBox.Text != "" && check == true)
                {
                    string selectedDep = empComboBox.SelectedItem.ToString();
                    string[] tiles = selectedDep.Split(' ');
                    int selectedDepID = Convert.ToInt32(tiles[ID_LOCATION_IN_STRING]);

                    SqlCommand cmdMax = new SqlCommand("SELECT MAX(ID) FROM employees", conn);
                    int max = Convert.ToInt32(cmdMax.ExecuteScalar());

                    SqlCommand cmdInsert = new SqlCommand("INSERT INTO employees (ID, LName, FName, MName, Birthday, Sex, DepartmentID) VALUES (@id, @lName, @fName, @mName, @birthday, @sex, @departmentId)", conn);
                    cmdInsert.Parameters.AddWithValue("@id", (max + ID_CORRECTION));
                    cmdInsert.Parameters.AddWithValue("@lName", lastNameTextBox.Text);
                    cmdInsert.Parameters.AddWithValue("@fName", firstNameTextBox.Text);
                    cmdInsert.Parameters.AddWithValue("@mName", secondNameTextBox.Text);
                    cmdInsert.Parameters.AddWithValue("@birthday", emp.Birthday);
                    cmdInsert.Parameters.AddWithValue("@sex", sexComboBox.SelectedItem.ToString());
                    cmdInsert.Parameters.AddWithValue("@departmentId", selectedDepID);
                    cmdInsert.ExecuteNonQuery();

                    alertTextBox.Clear();
                    alertTextBox.Visible = false;
                    this.Close();
                }
                else
                {
                    if (lastNameTextBox.Text == "" || firstNameTextBox.Text == "" || secondNameTextBox.Text == "" || yearTextBox.Text == "" || monthTextBox.Text == "" || dayTextBox.Text == "")
                    {
                        alertTextBox.Text = "Не все поля заполнены";
                        alertTextBox.Visible = true;
                    }
                }

                conn.Close();

                check = true;
                activation = true;
            }
        }

        private void yearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void monthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void dayTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
