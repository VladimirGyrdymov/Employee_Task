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
    public partial class EditingEmployeeForm : Form
    {
        public EditingEmployeeForm(int id, string lName, string fName, string mName, DateTime dateTime, string sex, int? depId)
        {
            InitializeComponent();
            employee.ID = id;
            employee.LName = lName;
            employee.FName = fName;
            employee.MName = mName;
            employee.Birthday = dateTime;
            switch (sex)
            {
                case "Мужской":
                    employee.Gender = Employee.Sex.Мужской;
                    break;
                case "Женский":
                    employee.Gender = Employee.Sex.Женский;
                    break;
                case "Другое":
                    employee.Gender = Employee.Sex.Другое;
                    break;
            }
            employee.DepartmentID = depId;
        }

        string connectionString = @"Data Source = ВЛАДИМИР-ПК\SQLEXPRESS; Initial Catalog = base; Trusted_Connection = True";
        string request;
        const int SELECT_CORRECTION = 1, ID_LOCATION_IN_STRING = 2;
        int index;
        bool check = true, birthdayCheck = true;
        Employee employee = new Employee();

        private void EditingEmployeeForm_Load(object sender, EventArgs e)
        {
            lastNameTextBox.Text = employee.LName;
            firstNameTextBox.Text = employee.FName;
            secondNameTextBox.Text = employee.MName;
            yearTextBox.Text = employee.Birthday.Year.ToString();
            monthTextBox.Text = employee.Birthday.Month.ToString();
            dayTextBox.Text = employee.Birthday.Day.ToString();

            sexComboBox.Items.Add(Employee.Sex.Мужской);
            sexComboBox.Items.Add(Employee.Sex.Женский);
            sexComboBox.Items.Add(Employee.Sex.Другое);
            sexComboBox.SelectedIndex = (int)employee.Gender;

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

            for (int i = 0; i < empComboBox.Items.Count; i++)
            {
                index = i;
                if (empComboBox.Items[i].ToString().Contains(employee.DepartmentID.ToString()) == true)
                {
                    break;
                }
            }

            empComboBox.SelectedIndex = index;

            conn.Close();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            employee.Birthday = new DateTime(Convert.ToInt32(yearTextBox.Text), Convert.ToInt32(monthTextBox.Text), Convert.ToInt32(dayTextBox.Text));

            string selectedDep = empComboBox.SelectedItem.ToString();
            string[] tiles = selectedDep.Split(' ');
            int selectedDepID = Convert.ToInt32(tiles[ID_LOCATION_IN_STRING]);
            employee.DepartmentID = selectedDepID;

            switch (sexComboBox.SelectedItem)
            {
                case Employee.Sex.Мужской:
                    employee.Gender = Employee.Sex.Мужской;
                    break;
                case Employee.Sex.Женский:
                    employee.Gender = Employee.Sex.Женский;
                    break;
                case Employee.Sex.Другое:
                    employee.Gender = Employee.Sex.Другое;
                    break;
            }

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT LName, FName, MName, Birthday, Sex, DepartmentID FROM employees";

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (lastNameTextBox.Text == reader.GetValue(0).ToString() && firstNameTextBox.Text == reader.GetValue(1).ToString() && secondNameTextBox.Text == reader.GetValue(2).ToString() && employee.Birthday.ToString() == reader.GetValue(3).ToString() && employee.Gender.ToString() == reader.GetValue(4).ToString() && employee.DepartmentID.ToString() == reader.GetValue(5).ToString())
                {
                    check = false;
                    alertTextBox.Text = "Совпадение с имеющейся записью";
                    alertTextBox.Visible = true;
                    break;
                }
            }

            reader.Close();

            if (yearTextBox.Text == "" || Convert.ToInt32(yearTextBox.Text) > 2010 || Convert.ToInt32(yearTextBox.Text) < 1900 || monthTextBox.Text == "" || Convert.ToInt32(monthTextBox.Text) > 12 || Convert.ToInt32(monthTextBox.Text) < 1 || dayTextBox.Text == "" || Convert.ToInt32(dayTextBox.Text) > 31 || Convert.ToInt32(dayTextBox.Text) < 1)
            {
                birthdayCheck = false;
                alertTextBox.Text = "Недопустимое значение ячейки";
                alertTextBox.Visible = true;
            }
            else
            {
                birthdayCheck = true;
            }

            if (lastNameTextBox.Text != "" && firstNameTextBox.Text != "" && secondNameTextBox.Text != "" && check == true && birthdayCheck == true)
            {
                request = "UPDATE employees SET LName = '" + lastNameTextBox.Text + "', FName = '" + firstNameTextBox.Text + "', MName = '" + secondNameTextBox.Text + "', Birthday = '" + employee.Birthday + "', Sex = '" + employee.Gender + "', DepartmentID = " + employee.DepartmentID + " WHERE ID = " + employee.ID;
                SqlCommand sqlUpdate = new SqlCommand(request, conn);
                sqlUpdate.ExecuteNonQuery();
                alertTextBox.Clear();
                alertTextBox.Visible = false;
                this.Close();
            }
            else
            {
                if (lastNameTextBox.Text == "" || firstNameTextBox.Text == "" || secondNameTextBox.Text == "" || yearTextBox.Text == "" || monthTextBox.Text == "" || dayTextBox.Text == "")
                {
                    alertTextBox.Text = "Не все значения введены";
                    alertTextBox.Visible = true;
                }
            }

            conn.Close();

            check = true;
        }
    }
}
