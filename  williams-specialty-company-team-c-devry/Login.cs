﻿/*****************************************************************************
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


            //connection string expamle for database--
            string connectionstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\WSCDB_V3.accdb;Persist Security Info=True;Jet OLEDB:Database Password=password";

            /***************************************************************************************
            * Lanuch code for checking login and password.
            * 
            * NOTE:Needs to have database call to accces the database and change code to reflect
            * the use of a database. I have hardcoded some values to facliate a login, check procedure
            * going to have to remove them sometime after everything else works
            * 
            * ***************************************************************************************/

            

            
            string Input_Login = Employee_ID.Text;  //variable to parse text entered into Login textbox
            string Input_Password = Password.Text; //variable to parse text entered into Password textbox
            
            //Select string for database//
            string selectstring = "SELECT User_ID, Emp_Password, Employee_Type FROM Employee";  
            OleDbConnection myconc = new OleDbConnection(connectionstring);

            
            OleDbCommand cmd = new OleDbCommand(selectstring, myconc); //new database command to send my string
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd); //new adapter for data
           
            DataSet ds = new DataSet(); // newdataset
                       
            adapter.Fill(ds); //fill the data set
            
            myconc.Close(); //clsoe connection

            //below see not working. i can login with anything
           if (ds.Tables[0].Rows.Count > 0)
                if (ds.Tables[0].Rows[0]["User_ID"].ToString() == Input_Login && ds.Tables[0].Rows[0]["Emp_Password"].ToString() == Input_Password && ds.Tables[0].Rows[0]["Employee_Type"].ToString() == "sales")
                
                    ds.Equals(true); 
            
            { 
            Sales frm = new Sales();
                        frm.ShowDialog();


                    }

                }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        }
        
        
    }
    
