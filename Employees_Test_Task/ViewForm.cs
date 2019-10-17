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
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source = ВЛАДИМИР-ПК\SQLEXPRESS; Initial Catalog = base; Trusted_Connection = True";
        bool check = true;

        private void GetData(string request, DataGridView dataGrid)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter(request, conn);
            DataTable table = new DataTable();
            sqlData.Fill(table);
            dataGrid.DataSource = table;
            dataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGrid.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            conn.Close();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            GetData("SELECT * FROM departments", depDataGridView);
            GetData("SELECT * FROM employees", empDataGridView);
        }

        private void refreshDepButton_Click(object sender, EventArgs e)
        {
            GetData("SELECT * FROM departments", depDataGridView);
        }

        private void refreshEmpButton_Click(object sender, EventArgs e)
        {
            GetData("SELECT * FROM employees", empDataGridView);
        }

        private void addDepButton_Click(object sender, EventArgs e)
        {
            AddingDepartmentForm addingDepartment = new AddingDepartmentForm();
            addingDepartment.Show();
        }

        private void editDepButton_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.ID = (int)depDataGridView["ID", depDataGridView.CurrentRow.Index].Value;
            department.DepartmentName = depDataGridView["DepartmentName", depDataGridView.CurrentRow.Index].Value.ToString();
            department.HeadEmployeeID = (int)depDataGridView["HeadEmployeeID", depDataGridView.CurrentRow.Index].Value;

            EditingDepartmentForm editingDepartment = new EditingDepartmentForm(department.ID, department.DepartmentName, department.HeadEmployeeID);
            editingDepartment.Show();
        }

        private void deleteDepButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmdUdpdateEmp = new SqlCommand("UPDATE employees SET DepartmentID = NULL WHERE DepartmentID = " + (int)depDataGridView["ID", depDataGridView.CurrentRow.Index].Value, conn);
            cmdUdpdateEmp.ExecuteNonQuery();
            SqlCommand cmdDelete = new SqlCommand("DELETE FROM departments WHERE ID = " + (int)depDataGridView["ID", depDataGridView.CurrentRow.Index].Value, conn);
            cmdDelete.ExecuteNonQuery();
            conn.Close();
        }

        private void addEmpButton_Click(object sender, EventArgs e)
        {
            AddingEmployeeForm addingEmployee = new AddingEmployeeForm();
            addingEmployee.Show();
        }

        private void editEmpButton_Click(object sender, EventArgs e)
        {
            string sex = null;
            Employee employee = new Employee();
            employee.ID = (int)empDataGridView["ID", empDataGridView.CurrentRow.Index].Value;
            employee.LName = empDataGridView["LName", empDataGridView.CurrentRow.Index].Value.ToString();
            employee.FName = empDataGridView["FName", empDataGridView.CurrentRow.Index].Value.ToString();
            employee.MName = empDataGridView["MName", empDataGridView.CurrentRow.Index].Value.ToString();
            employee.Birthday = Convert.ToDateTime(empDataGridView["Birthday", empDataGridView.CurrentRow.Index].Value);
            switch (empDataGridView["Sex", empDataGridView.CurrentRow.Index].Value.ToString())
            {
                case "Мужской":
                    sex = "Мужской";
                    break;
                case "Женский":
                    sex = "Женский";
                    break;
                case "Другое":
                    sex = "Другое";
                    break;
            }
            employee.DepartmentID = (int)empDataGridView["DepartmentID", empDataGridView.CurrentRow.Index].Value;

            EditingEmployeeForm editingEmployee = new EditingEmployeeForm(employee.ID, employee.LName, employee.FName, employee.MName, employee.Birthday, sex, employee.DepartmentID);
            editingEmployee.Show();
        }

        private void deleteEmpButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT HeadEmployeeID FROM departments";

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (empDataGridView["ID", empDataGridView.CurrentRow.Index].Value.ToString() == reader.GetValue(0).ToString())
                {
                    check = false;
                    alertTextBox.Text = "Нельзя удалить руководителя отдела";
                    alertTextBox.Visible = true;
                    break;
                }
            }

            reader.Close();
            if (check == true)
            {
                alertTextBox.Visible = false;
                SqlCommand cmdUdpdateDep = new SqlCommand("UPDATE departments SET HeadEmployeeID = NULL WHERE HeadEmployeeID = " + (int)empDataGridView["ID", empDataGridView.CurrentRow.Index].Value, conn);
                cmdUdpdateDep.ExecuteNonQuery();
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM employees WHERE ID = " + (int)empDataGridView["ID", empDataGridView.CurrentRow.Index].Value, conn);
                cmdDelete.ExecuteNonQuery();
            }
            conn.Close();

            check = true;
        }
    }
}
