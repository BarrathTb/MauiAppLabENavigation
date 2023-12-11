using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MauiAppLabENavigation.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BMIPage : ContentPage
    {
        public BMIPage()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-FR");
        }


        void Button_Clicked(object sender, EventArgs e)
        {
            double weightInLbs = Convert.ToDouble(In_Weight.Text);
            double heightInInches = Convert.ToDouble(In_Height.Text);


            double bmi = ((weightInLbs / (heightInInches * heightInInches)) * 703);
            Out_Text.Text = bmi.ToString();
        }
    }
}