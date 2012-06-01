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
          
         string UserID = ""; //User ID  is string variable so we can check login--need to remove hardcode login
         string UserPass = ""; //UserPass is string varaiable for checking password-- needw to remove hardcoded password

        

         string Input_Login = Employee_ID.Text;  //variable to parse text entered into Login textbox
         string Input_Password = Password.Text; //variable to parse text entered into Password textbox

         
        
        private void Login_Load(object sender, EventArgs e)
        {

        }
        
    }
}
