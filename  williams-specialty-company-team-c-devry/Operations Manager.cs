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

            int status = 0;
            int record;
            //connection string expamle for database--
            string connectionstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\WSCDB_V3.accdb;Persist Security Info=True;Jet OLEDB:Database Password=password";

            OleDbConnection myconc = new OleDbConnection(connectionstring);//connection string for order number
            string selectstring = "Select Order_Number FROM Order"; //slect string to see if there is a order number 
            myconc.Open(); //open connection I am not sure where to put this.
            OleDbCommand cmd = new OleDbCommand(selectstring, myconc); //new database command to send my string
            OleDbDataReader myReader; 
            myReader = cmd.ExecuteReader(); //execute reader

            while (myReader.Read() == true)
            {
                record = (int)myReader[0];
                txtOrdDate.Text.ToString();
                txtFirstName.Text.ToString();
                txtStreet.Text.ToString();
                txtState.Text.ToString();
                txtZip.Text.ToString();
                txtPhone.Text.ToString();
                txtEmail.Text.ToString();
                status = (int)myReader[7];
                if (status == 1)
                    txtOrdDate.Text.Equals(0);
                MessageBox.Show("no record exists ");

                //else 
                //MessageBox.Show("record exists");
                myReader.Close();

            }

        }


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

