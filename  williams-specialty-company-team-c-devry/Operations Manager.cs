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
            int record = 0;
            string ordernumber = txtOrdNum.Text;
            //connection string expamle for database--
            string connectionstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\WSCDB_V3.accdb;Persist Security Info=True;Jet OLEDB:Database Password=password";
           
            OleDbConnection myconc = new OleDbConnection(connectionstring);//connection string for order number
            string selectstring = "Select Order_Number FROM [Order] where Order_Number ='" + txtOrdNum.Text + "'"; //select string to see if there is a order number 
            myconc.Open(); //open connection I am not sure where to put this.
            OleDbCommand cmd = new OleDbCommand(selectstring, myconc); //new database command to send my string
            OleDbDataReader myReader; 
            myReader = cmd.ExecuteReader(); //execute reader
            int order = Convert.ToInt32(txtOrdNum.Text);

            //if (order == Order_number) ;
            while (myReader.Read() == true)
            {
               

                record = (int)myReader[0];
                txtOrdNum.Text = (string)myReader[1];
                txtOrdDate.Text = (string) myReader[2];
                txtFirstName.Text = (string) myReader[3];
                txtStreet.Text = (string) myReader[4];
                txtState.Text = (string) myReader[5];
                txtZip.Text = (string) myReader[6];
                txtPhone.Text = (string) myReader[7];
                txtEmail.Text = (string) myReader[8];
                status = (int)myReader[9];
                if (status == null)
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

