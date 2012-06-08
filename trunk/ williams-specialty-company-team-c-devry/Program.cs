/*****************************************************************************
 * Program: WSC Business Automation
 * File: Program.cs
 * By: Team C    
 * 
 * 
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WSC_Business_Automation_test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*Application.Run(new Employee());
            Application.Exit();*/

           Login f1 = new Login();
            DialogResult dr = f1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (EmployeeInfo.employeeType == "Sales Person")
                {
                    Application.Run(new Sales());
                }
                else if (EmployeeInfo.employeeType == "OP Manager")
                {
                    Application.Run(new Operations_Manager());
                }
                else if (EmployeeInfo.employeeType == "P/E Specialist")
                {
                    Application.Run(new Print_Engrave_Specialist());
                }
            }
            else
            {
                Application.Exit();
            }
            //Application.Run(new Login());
        }
    }
}
