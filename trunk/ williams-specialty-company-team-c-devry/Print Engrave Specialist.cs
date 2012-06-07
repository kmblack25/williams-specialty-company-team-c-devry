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

namespace WSC_Business_Automation_test
{
    public partial class Print_Engrave_Specialist : Form
    {
        public Print_Engrave_Specialist()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Print_Engrave_Specialist_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //search button
        {
            //connection string expamle for database--
            string connectionstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\WSCDB_V3.accdb;Persist Security Info=True;Jet OLEDB:Database Password=password";
        }

        private void button3_Click(object sender, EventArgs e) //update button
        {
            //connection string expamle for database--
            string connectionstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\WSCDB_V3.accdb;Persist Security Info=True;Jet OLEDB:Database Password=password";
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
