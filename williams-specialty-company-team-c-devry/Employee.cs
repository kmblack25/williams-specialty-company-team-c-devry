/*****************************************************************************
 * Program: WSC Business Automation
 * File: Print Engrave Specialist.cs
 * By: Team C    
 * Professor Margaret Kozak
 * 
 * 
 * 
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace WSC_Business_Automation_test
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wSCDB_V3DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.wSCDB_V3DataSet.Customers);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string customerId = dataGridCustomers.Rows[e.RowIndex].Cells[4].Value.ToString();
                DataRow dr = getCustomerDR(customerId);
                textFirstName.Text = dr["First_Name"].ToString();
                textLastName.Text = dr["Last_Name"].ToString();

                textStreet.Text = dr["Street_Address"].ToString();
                textCity.Text = dr["City"].ToString();
                textState.Text = dr["State"].ToString();
                textZipCode.Text = dr["Zip_Code"].ToString();

                textBillingStreet.Text = dr["Cust_Billing_Address"].ToString();
                textBillingCity.Text = dr["Customer_ Billing_City"].ToString();
                textBillingState.Text = dr["Customer_Billing_State"].ToString();
                textBillingZipCode.Text = dr["Customer_Billing_Zip"].ToString();
                
                textPhone.Text = dr["Phone"].ToString();
                textEmail.Text = dr["Email"].ToString();
            }
            catch (Exception e1)
            {

            }
        }

        private DataRow getCustomerDR(string customerId)
        {
            string sql = "SELECT Customer.*, Person.*" +
                         "  FROM (Customer INNER JOIN Person ON Customer.Customer_ID = Person.Customer_ID)" +
                         " Where Customer.Customer_ID=" + customerId;

            //open connection
            ConnectionStringSettings connection = ConfigurationManager.ConnectionStrings["WSCDB_V3ConnectionString"];
            OleDbConnection myconc = new OleDbConnection(connection.ConnectionString);
            myconc.Open();

            //Execute Query and get dataset
            OleDbCommand cmd = new OleDbCommand(sql, myconc); //new database command to send my string
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd); //new adapter for data
            DataSet ds = new DataSet(); // newdataset
            adapter.Fill(ds); //fill the data set

            return ds.Tables[0].Rows[0];
        }

    }
}
