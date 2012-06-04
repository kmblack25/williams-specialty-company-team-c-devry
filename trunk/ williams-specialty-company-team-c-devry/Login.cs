/*****************************************************************************
 * Program: WSC Business Automation
 * File: Login.cs
 * By: Team C    
 * 
 * Loign.cs captures login/paasword and checks against database if correct launches
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


            //connection string expamle for database--
            //string ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\abc.mdb;Jet OLEDB:Database Password=password";


            /***************************************************************************************
            * Lanuch code for checking login and password.
            * 
            * NOTE:Needs to have database call to accces the database and change code to reflect
            * the use of a database. I have hardcoded some values to facliate a login, check procedure
            * going to have to remove them sometime after everything else works
            * 
            * ***************************************************************************************/

            string UserID = "sales"; //User ID  is string variable so we can check login--need to remove hardcode login
            string UserPass = "password"; //UserPass is string varaiable for checking password-- needw to remove hardcoded password

            //start temp variables for login check
            string USERID1 = "ops";
            string USERID2 = "print";
            //End temp variables for login check--remove when no longer needed 

            string Input_Login = Employee_login.Text;  //variable to parse text entered into Login textbox
            string Input_Password = Password.Text; //variable to parse text entered into Password textbox


            //I think that it would be easier to check the username and password against the USERID and UserPass variables once 
            //and then do a nested if statement to check the department. Even though we will be changing it. This should work.
            //your if statement to validate login. 

            //if-else stsements tp launch differnt interfaces
            if (UserID == Input_Login || USERID1 == Input_Login || USERID2 == Input_Login && UserPass == Input_Password)  // this will accept all departments
            {
                MessageBox.Show("Login was successful!");
                if (Input_Login == UserID) //this will open Sales form if sales was typed in for username
                {
                    Sales frm = new Sales();
                    frm.ShowDialog();
                }
                else if (Input_Login == USERID1)
                {
                    Operations_Manager frm = new Operations_Manager();
                    frm.ShowDialog();
                    
                }
                else if (Input_Login == USERID2)
                {
                    Print_Engrave_Specialist frm = new Print_Engrave_Specialist();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No Department was specified");//can't happen because it wouldn't log them in
                }

            }
            else //if login credentials fail it jumps here and won't log in.
            {
                MessageBox.Show("incorrect login or password. Please Try again", "Input Error");
                Employee_login.Clear();
                Password.Clear();
                return;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}