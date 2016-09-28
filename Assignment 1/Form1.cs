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

namespace Assignment_1
{
    public partial class InitialForm : Form
    {
        
        public InitialForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          // declare variables with relevant names
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
               HoursWorked = double.Parse(HoursWorkedTextBox.Text);
                if (HoursWorked >160 && HoursWorked < 0)
                {
                    Console.WriteLine("please enter hours less than 160 and more than 0");

                }
                else
                {


                    TotalMonthlySales = double.Parse(TotalSalesTextBox.Text);

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

        private void button2_Click(object sender, EventArgs e)
        {
            print printed = new print();
            // reference to the current form in a property of the nextform
            printed.previousForm = this;
            // show the next form 
            printed.Show();
            this.Hide();
        }
    }
}
