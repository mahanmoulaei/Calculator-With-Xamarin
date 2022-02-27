using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatorPage2 : ContentPage
    {
        double num1, num2;
        string operation;

        public CalculatorPage2()
        {
            InitializeComponent();
        }

        private void onCLickNumber(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (lblResult.Text == "0")
            {
                lblResult.Text = "";
            }
            lblResult.Text += btn.Text;

        }

        private void onCLickOperation(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            operation = btn.Text;
            num1 = Convert.ToDouble(lblResult.Text);
            lblResult.Text = "0";

        }

        private void onCLickEqual(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(lblResult.Text);

            lblResult.Text = Convert.ToString(Calculator.Calculate(num1, num2, operation));

        }

        private void onCLickClear(object sender, EventArgs e)
        {
            num1 = num2 = 0;
            operation = null;
            lblResult.Text = "0";
        }
    }
}