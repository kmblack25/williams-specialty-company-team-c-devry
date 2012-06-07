/*****************************************************************************
 * Program: WSC Business Automation
 * File: Sales.cs
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
using System.Data.OleDb;

namespace WSC_Business_Automation_test
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //new order button 
        {
            
        }

        private void button2_Click(object sender, EventArgs e) //search button
        {
            
        }

        private void button3_Click(object sender, EventArgs e) //update button
        {
            Boolean isInsert = false;
            if (textOrderNumber.Text != "")
            {
                isInsert = true;
            }

            String sql = "";

            if (isInsert)
            {
                Int32 orderNumber = getNextOrderNumber();
                sql += "Insert into Order(Order_Number, Order_Type, Order_Description, Order_Eng_Print, Order_Date," +
                       "                  Order_Status, Order_Quantity, Customer_ID, Employee_ID, Employee_ID_2, Cost_ID, Expected_Delivery_date,"+
                       "                  Ordered_Print, Ordered_Picture, Payment_Status, Payment_Type, Order_Total, Total_Payments_Received)" +
                       "          Values (" + orderNumber + ",1,'descr',1," + DateTime.Now + ",)" + 
                       "                  1, 1, ";
            }



            
        }

        public static Int32 getNextOrderNumber()
        {
            string sql = "SELECT MAX(Order_Number) AS Expr1 FROM [Order]";

            //open connection
            ConnectionStringSettings connection = ConfigurationManager.ConnectionStrings["WSCDB_V3ConnectionString"];
            OleDbConnection myconc = new OleDbConnection(connection.ConnectionString);
            myconc.Open();

            //Execute Query and get dataset
            OleDbCommand cmd = new OleDbCommand(sql, myconc); //new database command to send my string
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd); //new adapter for data
            DataSet ds = new DataSet(); // newdataset
            adapter.Fill(ds); //fill the data set


            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                return Int32.Parse(ds.Tables[0].Rows[0][0].ToString()) + 1;
            }
            else
            {
                return 1;
            }
        }
    }
}
