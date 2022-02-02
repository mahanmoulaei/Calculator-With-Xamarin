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
    public partial class Buttons : ContentPage
    {
        public Buttons()
        {
            InitializeComponent();

            buttonTest.Text = "Changed Text By Code";
            buttonTest.Clicked += (object sender, EventArgs e) =>
            {
                if (labelTest.TextColor != Color.Red)
                {
                    labelTest.TextColor = Color.Red;
                } else
                {
                    labelTest.TextColor = Color.Green;
                }
                
            };
        }

        private void buttonBorder_Clicked(object sender, EventArgs e)
        {
            if (labelTest.TextColor != Color.White)
            {
                labelTest.TextColor = Color.White;
            }
            else
            {
                labelTest.TextColor = Color.Black;
            }
        }
    }
}