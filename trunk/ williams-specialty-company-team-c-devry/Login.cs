/*****************************************************************************
 * Program: WSC Business Automation
 * File: Login.cs
 * By: Team C    
 * 
 * Loign.cs captures login/pasword and checks against database if correct launches
 * correct interface else throws error
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
using System.Data.OleDb; //needed for access

namespace WSC_Business_Automation_test
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /***************************************************************************************
            * Lanuch code for checking login and password.
            * 
            * NOTE:Needs to have database call to accces the database and change code to reflect
            * the use of a database. I have hardcoded some values to facliate a login, check procedure
            * going to have to remove them sometime after everything else works
            * 
            * ***************************************************************************************/

            //Read form values
            string Input_Login = Employee_ID.Text;  //variable to parse text entered into Login textbox
            string Input_Password = Password.Text; //variable to parse text entered into Password textbox

            //Select Sql
            string selectstring = "SELECT Employee_ID, User_ID, Emp_Password, Employee_Type FROM Employee WHERE user_Id='" + Input_Login + "' AND  emp_password='" + Input_Password + "'";

            //open connection
            ConnectionStringSettings connection = ConfigurationManager.ConnectionStrings["WSCDB_V3ConnectionString"];
            OleDbConnection myconc = new OleDbConnection(connection.ConnectionString);
            myconc.Open();
            
            //Execute Query and get dataset
            OleDbCommand cmd = new OleDbCommand(selectstring, myconc); //new database command to send my string
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd); //new adapter for data
            DataSet ds = new DataSet(); // newdataset
            adapter.Fill(ds); //fill the data set

            //If Number of rows returned is not 0 then login is successful
            if (ds.Tables[0].Rows.Count!=0)
            {
                //message to user
                MessageBox.Show("Login was successful");
                
                //Populate logged in employee info
                EmployeeInfo.employeeId = ds.Tables[0].Rows[0]["Employee_ID"].ToString();
                EmployeeInfo.userId = ds.Tables[0].Rows[0]["User_ID"].ToString();
                EmployeeInfo.employeeType = ds.Tables[0].Rows[0]["Employee_Type"].ToString();
                
                //close this dialog with success
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Login was unsuccessful, Please try again");
            }

            //close connection
            myconc.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
