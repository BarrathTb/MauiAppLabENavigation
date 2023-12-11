using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppLabENavigation.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]


    public partial class MorseCode : ContentPage
    {
        public MorseCode()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-FR");
        }

        private string currentMorseCode = "";
        private string decodedText = "";



        private void Dot_Clicked(object sender, EventArgs e)
        {
            currentMorseCode += ".";
            UpdateDotsAndDashesLabel();

        }

        private void Dash_Clicked(object sender, EventArgs e)
        {
            currentMorseCode += "-";
            UpdateDotsAndDashesLabel();
        }

        private void Space_Clicked(object sender, EventArgs e)
        {
            if (currentMorseCode == "")
            {
                decodedText += " "; // Add a space for a new word
            }
            else
            {
                char letter = Morse.MorseCoder(currentMorseCode);
                decodedText += letter;
            }

            currentMorseCode = ""; // Reset the current Morse code
            UpdateDotsAndDashesLabel();
            UpdateLettersAndWordsLabel();
        }

        private void UpdateDotsAndDashesLabel()
        {
            dotsAndDashesLabel.Text = currentMorseCode;
            dotsAndDashesLabel2.Text = currentMorseCode;
        }

        private void UpdateLettersAndWordsLabel()
        {
            lettersAndWordsLabel.Text = decodedText;

        }
    }
}