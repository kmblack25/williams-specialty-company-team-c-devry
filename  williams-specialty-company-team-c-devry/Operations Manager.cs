/*****************************************************************************
 * Program: WSC Business Automation
 * File: Operations Manager.cs
 * By: Team C    
 * 
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
using System.Data.OleDb; //needed for access

namespace WSC_Business_Automation_test
{
    public partial class Operations_Manager : Form
    {
        public Operations_Manager()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Operations_Manager_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //search button
        {

        } //connection string expamle for database--
        string connectionstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\WSCDB_V3.accdb;Persist Security Info=True;Jet OLEDB:Database Password=password";

        private void button3_Click(object sender, EventArgs e) //update button
        {
            //connection string expamle for database--
            string connectionstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\WSCDB_V3.accdb;Persist Security Info=True;Jet OLEDB:Database Password=password";
        }

        private void button1_Click(object sender, EventArgs e) //asign button
        {
            //connection string expamle for database--
            string connectionstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\WSCDB_V3.accdb;Persist Security Info=True;Jet OLEDB:Database Password=password";
        }
    }
}
