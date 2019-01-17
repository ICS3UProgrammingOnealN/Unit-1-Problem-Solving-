/*
 * Created by: Oneal Nnah
 * Created on: 5th january 2002
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 - Name of Program
 * This program...
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCostOneal
{
    public partial class PizzaCostForm : Form
    {
        public PizzaCostForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double diameter, Subtotal, Total, HST;

            //Convert the diameter to a double 
            diameter = (double)nudDiameter.Value;

            // calculate the cost before and after tax
            Subtotal = 0.99 + 0.75 + 0.5 * diameter;
            HST = 0.13 * Subtotal;
            Total = Subtotal + HST;

            //display the cost in Label, rounded to 2 decimal places
            lblAnwer.Text = String.Format("${0:0.00}", Total);
        
        }

        private void lblCostAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
