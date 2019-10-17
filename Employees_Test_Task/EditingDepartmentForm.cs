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
    public partial class EditingDepartmentForm : Form
    {
        public EditingDepartmentForm(int id, string depName, int? headId)
        {
            InitializeComponent();
            department.ID = id;
            department.DepartmentName = depName;
            department.HeadEmployeeID = headId;
        }

        string connectionString = @"Data Source = ВЛАДИМИР-ПК\SQLEXPRESS; Initial Catalog = base; Trusted_Connection = True";
        bool check = true;
        const int SELECT_CORRECTION = 1, ID_LOCATION_IN_STRING = 2;
        int index = 0;
        Department department = new Department();

        private void EditingDepartmentForm_Load(object sender, EventArgs e)
        {
            editDepTextBox.Text = department.DepartmentName;
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT ID, LName, FName, MName FROM employees";

            editDepComboBox.Items.Clear();

            SqlDataReader reader = cmd.ExecuteReader();

            string tmp;

            while (reader.Read())
            {
                tmp = "ID - " + reader.GetValue(0).ToString() + " - " + reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString() + " " + reader.GetValue(3).ToString();
                editDepComboBox.Items.Add(tmp);
            }

            reader.Close();

            for (int i = 0; i < editDepComboBox.Items.Count; i++)
            {
                index = i;
                if (editDepComboBox.Items[i].ToString().Contains(department.HeadEmployeeID.ToString()) == true)
                {
                    break;
                }
            }

            editDepComboBox.SelectedIndex = index;

            conn.Close();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            string selectedHeadDep = editDepComboBox.SelectedItem.ToString();
            string[] tiles = selectedHeadDep.Split(' ');
            int selectedHeadDepID = Convert.ToInt32(tiles[ID_LOCATION_IN_STRING]);
            department.HeadEmployeeID = selectedHeadDepID;
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT DepartmentName, HeadEmployeeID FROM departments";

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (editDepTextBox.Text == reader.GetValue(0).ToString() && department.HeadEmployeeID.ToString() == reader.GetValue(1).ToString())// проверить необходимость второго условия
                {
                    check = false;
                    alertTextBox.Text = "Совпадение с имеющейся записью";
                    alertTextBox.Visible = true;
                    break;
                }
            }

            reader.Close();

            if (editDepTextBox.Text != "" && check == true)
            {
                SqlCommand sqlDepUpdate = new SqlCommand("UPDATE departments SET DepartmentName = '" + editDepTextBox.Text + "', HeadEmployeeID = " + department.HeadEmployeeID + "WHERE ID = " + department.ID, conn);
                sqlDepUpdate.ExecuteNonQuery();
                SqlCommand sqlEmpUpdate = new SqlCommand("UPDATE employees SET DepartmentID = " + department.ID + " WHERE ID = " + department.HeadEmployeeID, conn);
                sqlEmpUpdate.ExecuteNonQuery();
                alertTextBox.Clear();
                alertTextBox.Visible = false;
                this.Close();
            }
            else
            {
                if (editDepTextBox.Text == "")
                {
                    alertTextBox.Text = "Не введено новое название";
                    alertTextBox.Visible = true;
                }
            }

            conn.Close();

            check = true;
        }
    }
}
