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
            string selectstring = "Select * FROM [Order]";  
            myconc.Open(); //open connection I am not sure where to put this.
            OleDbCommand cmd = new OleDbCommand(selectstring, myconc); //new database command to send my string
            OleDbDataReader myReader; 
            myReader = cmd.ExecuteReader(); //execute reader
            

            //if (order == Order_number) ;
            while (myReader.Read() == true)
            {
               

                record = (int)myReader[0];
                txtOrdNum.Text = (string) myReader[1];
                txtOrdDate.Text = (string) myReader[2];
                txtFirstName.Text = (string) myReader[3];
                txtStreet.Text = (string) myReader[4];
                txtState.Text = (string) myReader[5];
                txtZip.Text = (string) myReader[6];
                txtPhone.Text = (string) myReader[7];
                txtEmail.Text = (string) myReader[8];
                txtAcctNum.Text = (string)myReader[9];
                txtPayType.Text = (string)myReader[10];
                txtJobType.Text = (string)myReader[11];
                txtMediaType.Text = (string)myReader[12];
                txtProdCont.Text = (string)myReader[13];
                txtAssignSpecialist.Text = (string)myReader[15];
                txtNote.Text = (string)myReader[16];

                status = (int)myReader[17];
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
            //string s for text boxes so we can update records
            string str1 = txtOrdNum.Text;
            string str2 = txtOrdDate.Text;
            string str3 = txtFirstName.Text;
            string str4 = txtStreet.Text;
            string str5 = txtState.Text;
            string str6 = txtZip.Text;
            string str7 = txtPhone.Text;
            string str8 = txtEmail.Text;
            string str9 = txtAcctNum.Text;
            string str10 = txtPayType.Text;
            string str11 = txtJobType.Text;
            string str12 = txtMediaType.Text;
            string str13 = txtProdCont.Text;
            string str14 = txtAssignSpecialist.Text;
            string str15=  txtNote.Text;
            //connection string expamle for database--
            string connectionstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\WSCDB_V3.accdb;Persist Security Info=True;Jet OLEDB:Database Password=password";

            OleDbConnection myconc = new OleDbConnection(connectionstring);//connection string for order number
            string selectstring = "Select * FROM [Order]"; //need to change 
            
                using (OleDbCommand cmd = new OleDbCommand(selectstring, myconc))
                {

                    cmd.CommandType = cmd.CommandType;
                    cmd.Parameters.AddWithValue
                    cmd.Parameters.AddWithValue
                    cmd.Parameters.AddWithValue
                    cmd.Parameters.AddWithValue
                    cmd.Parameters.AddWithValue
                    cmd.Parameters.AddWithValue
                    cmd.Parameters.AddWithValue
                    cmd.Parameters.AddWithValue

                    myconc.Open();
                    cmd.ExecuteNonQuery();


                }


            //update

        }

        private void button1_Click(object sender, EventArgs e) //asign button
        {
            //connection string expamle for database--
            string connectionstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\WSCDB_V3.accdb;Persist Security Info=True;Jet OLEDB:Database Password=password";
        }

        private void txtOrdNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

