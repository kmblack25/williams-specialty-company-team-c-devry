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
            // TODO: This line of code loads data into the 'wSCDB_V3DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.wSCDB_V3DataSet.Employee);

        }

        private void button2_Click(object sender, EventArgs e) //search button
        {

        } 
        

        private void button3_Click(object sender, EventArgs e) //update button
        {
            
        }

        private void button1_Click(object sender, EventArgs e) //asign button
        {
            
        }
    }
}
