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
    public partial class AddingDepartmentForm : Form
    {
        public AddingDepartmentForm()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source = ВЛАДИМИР-ПК\SQLEXPRESS; Initial Catalog = base; Trusted_Connection = True";
        const int ID_LOCATION_IN_STRING = 2, ID_CORRECTION = 1;
        bool check = true;

        private void AddingDepartmentForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT ID, LName, FName, MName FROM employees";

            headEmpComboBox.Items.Clear();

            SqlDataReader reader = cmd.ExecuteReader();

            string tmp;

            while (reader.Read())
            {
                tmp = "ID - " + reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString() + " " + reader.GetValue(3).ToString();
                headEmpComboBox.Items.Add(tmp);
            }

            reader.Close();

            headEmpComboBox.SelectedIndex = 0;

            conn.Close();
        }

        private void createDepButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT DepartmentName FROM departments";

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (inputDepNameTextBox.Text == reader.GetValue(0).ToString())
                {
                    check = false;
                    alertTextBox.Text = "Такое название отдела существует";
                    alertTextBox.Visible = true;
                    break;
                }
            }

            reader.Close();

            if (inputDepNameTextBox.Text != "" && check == true)
            {

                string selectedHeadEmp = headEmpComboBox.SelectedItem.ToString();
                string[] tiles = selectedHeadEmp.Split(' ');
                int selectedHeadEmpID = Convert.ToInt32(tiles[ID_LOCATION_IN_STRING]);

                SqlCommand cmdMax = new SqlCommand("SELECT MAX(ID) FROM departments", conn);
                int max = Convert.ToInt32(cmdMax.ExecuteScalar());

                SqlCommand cmdInsert = new SqlCommand("INSERT INTO departments (ID, DepartmentName, HeadEmployeeID) VALUES (@id, @departmentName, @headEmployeeID)", conn);
                cmdInsert.Parameters.AddWithValue("@id", (max + ID_CORRECTION));
                cmdInsert.Parameters.AddWithValue("@departmentName", inputDepNameTextBox.Text);
                cmdInsert.Parameters.AddWithValue("@headEmployeeID", selectedHeadEmpID);
                cmdInsert.ExecuteNonQuery();

                SqlCommand cmdUpdate = new SqlCommand("UPDATE employees SET DepartmentID = " + (max + ID_CORRECTION) + "WHERE ID = " + selectedHeadEmpID, conn);
                cmdUpdate.ExecuteNonQuery();
                alertTextBox.Clear();
                alertTextBox.Visible = false;
                this.Close();
            }
            else
            {
                if (inputDepNameTextBox.Text == "")
                {
                    alertTextBox.Text = "Не введено название";
                    alertTextBox.Visible = true;
                }
            }

            conn.Close();

            check = true;
        }
    }
}
