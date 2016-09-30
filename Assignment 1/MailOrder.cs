using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * App name is Assignment 1
 * Made by Balwinder Singh (200326404)
 * App creation date 29/september/2016
 * App description - calculate the sales bonus of an employee
 * 
 * 
 */

namespace Assignment_1
{
    public partial class MailOrder : Form
    {
        
        public MailOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // declare variables with relevant names
            String EmployeeName;
            int EmployeeID;
            Double PercentageOfHoursWorked;
            Double HoursWorked;
            Double TotalMonthlySales;
            Double TotalBonusAmount;
            Double salesBonus;
            //  double SalesBonus;
      
            // validation the data 
            try
            {
                //  Double employeeName = Convert.ToChar(EmployeeNameTextBox.Text);
                //    Double employeeID = Convert.ToDouble(EmployeeIDTextBox.Text);

                EmployeeName = Convert.ToString(EmployeeNameTextBox.Text);
                EmployeeID = Convert.ToInt16(EmployeeIDTextBox.Text);
                HoursWorked = double.Parse(HoursWorkedTextBox.Text);
                TotalMonthlySales = double.Parse(TotalSalesTextBox.Text);
                if (HoursWorked > 160 || HoursWorked <0)
                {
                    MessageBox.Show("Please enter a value less than 160 and greater than 0. !! no negative numbers!!");
                    ClearContent(this.Controls);

                }
                else 
                {

                    

                    TotalBonusAmount = TotalMonthlySales * 0.02;//=2
                    PercentageOfHoursWorked = HoursWorked / 160; // 0.25
                    salesBonus = PercentageOfHoursWorked * TotalBonusAmount;




                    // show the sales bonus amount in $
                    SalesBonusTextBox.Text = salesBonus.ToString("C2");

                }
                         }
                         catch (Exception exception)
            {
                


              MessageBox.Show("Invalid Data Entered", "Input Error");
                 
                             }

            }
     
        // this is the coding for 2nd button that is print button
        private void PrintButton_Click(object sender, EventArgs e)
        {
            print printed = new print();
            // reference to the current form in a property of the nextform
            printed.previousForm = this;
            // show the next form 
            printed.Show();
            this.Hide();
        }
    
        // this is the coding for 3rd button that is clear button
        private void button3_Click(object sender, EventArgs e)
        {
            // clear all content of form according to the coding of function
            ClearContent(this.Controls);
        }

     // this function will clear some the content of some textboxes
        private void ClearContent(Control.ControlCollection textboxes)
        {
            foreach (Control clear in textboxes)
            {
                TextBox TextboxSpace = clear as TextBox;
                if (TotalSalesTextBox != null)
                {
                    EmployeeNameTextBox.Clear();
                    EmployeeIDTextBox.Clear();
                    HoursWorkedTextBox.Clear();
                    SalesBonusTextBox.Clear();
                }
                else
                {
                    ClearContent(clear.Controls);
                }
            }
        }
    }
}
