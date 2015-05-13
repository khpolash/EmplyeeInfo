using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInfo
{
    public partial class Form1 : Form
    {
        String connStr = @"SERVER=PC-301-26\SQLEXPRESS;Database=employee;integrated security = true";
       
        public Form1()
        {
            InitializeComponent();
        }

        public bool isUpdateMode;
        public string empID;
        private void saveButton_Click(object sender, EventArgs e)
        {

            empID = empIDTextBox.Text;
            string name = employNameTextBox.Text;
            string address = employAddressTextBox.Text;
            string email = employEmailTextBox.Text;
            var salary = Convert.ToDouble(employSalaryTextBox.Text);


            SqlConnection connection = new SqlConnection(connStr);
            string qurery = "INSERT INTO employ_info(EmployID, Name, Address, Email, Salary) Values('" + empID + "','" + name + "','" + address +
                            "','" + email + "', '" + salary + "')";
            SqlCommand aSqlCommand = new SqlCommand(qurery, connection);

            connection.Open();
            int row = aSqlCommand.ExecuteNonQuery();
            MessageBox.Show("Data successfully Insert...");
            connection.Close();

            }

        private void showButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connStr);
            string qurery = "SELECT * FROM employ_info";
            SqlCommand aSqlCommand = new SqlCommand(qurery, connection);
            connection.Open();
            SqlDataReader dataReader = aSqlCommand.ExecuteReader();
            employInfoDataGridView.Rows.Clear();
            while (dataReader.Read())
            {
                
                employInfoDataGridView.Rows.Add(dataReader[1].ToString(),dataReader[2].ToString(), dataReader[3].ToString(),
                    dataReader[4].ToString(), dataReader[5].ToString());
            }
            dataReader.Close();
            connection.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connStr);

            string qurery = "DELETE FROM employ_info where ID ='"+deleteEmployIDTextBox.Text+"'";

            SqlCommand aSqlCommand = new SqlCommand(qurery, connection);

            connection.Open();
            int row = aSqlCommand.ExecuteNonQuery();
            MessageBox.Show(@"Employee successfully Deleted.");
            connection.Close();
        }

        private void OnMouseClick(object sender, MouseEventArgs e)
        {

        }

    }
}
