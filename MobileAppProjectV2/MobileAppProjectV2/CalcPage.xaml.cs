using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppProjectV2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalcPage : ContentPage
    {
        //variables
        
        string myoperator = " ";
        int mainNumber1 = 0, mainNumber2 = 0;
        int resultNumber1 = 0, resultNumber2 = 0;

        public CalcPage()
        {
           
            InitializeComponent();
            //setting the values to 8000 at the beginning of each new game
            resultText.Text = "8000";
            resultText2.Text = "8000";

            //converting the .text values of resultText to ints
            resultNumber1 = Convert.ToInt32(resultText.Text);
            resultNumber2 = Convert.ToInt32(resultText2.Text);
            
        }
        //method that sets up the grid
        private void setUpGrid()
        {
            var Grid = new Grid();
            GridSetUp.ColumnDefinitions = new ColumnDefinitionCollection();
            // rows
            GridSetUp.RowDefinitions = new RowDefinitionCollection();
        }
       
        //method that when called sets the number for the red side based on the text value of the button pressed
        void OnSelectNumberRed(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int numberPressed = 0;
            numberPressed = Convert.ToInt32(button.Text);
            mainNumber1 = numberPressed;
        }
        //method that when called sets the number for the blue side based on the text value of the button pressed
        void OnSelectNumberBlue(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int numberPressed = 0;
            numberPressed = Convert.ToInt32(button.Text);
            mainNumber2 = numberPressed;
        }
        //method that when called sets the operator for the red side based on the text value of the button pressed
        void OnSelectOperaterRed(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
            string pressed = button.Text;
            myoperator = pressed;
        }
        //method that when called sets the number for the blue side based on the text value of the button pressed
        void OnSelectOperaterBlue(object sender, EventArgs e) 
        {

            Button button = (Button)sender;
            string pressed = button.Text;
            myoperator = pressed;
        }
        //method that when called sets the result numbers for both sides when the new game button is pressed
        private void OnSelectNewGame(object sender, EventArgs e)
        {
            resultText.Text = "8000";
            resultText2.Text = "8000";
            resultNumber1 = 8000;
            resultNumber2 = 8000;
        }
        //method that calculates the result currently to the blue side
        void OnCalculateBlue(object sender, EventArgs e)
        {
            var result = 0;
           
                 result = OperatorHelper.Calculate(mainNumber2, resultNumber2, myoperator);
                String stringresult = Convert.ToString(result);
            resultNumber2 = Convert.ToInt32(stringresult);
                resultText.Text = stringresult;
            
            
        }
        //method that calculates the result currently to the blue side
        void OnCalculateRed(object sender, EventArgs e) 
        {
            var result = 0;
            
            result = OperatorHelper.Calculate(mainNumber1, resultNumber1, myoperator);
                String stringresult = Convert.ToString(result);
                resultNumber1 = Convert.ToInt32(stringresult);
                resultText2.Text = stringresult;
                
                
            
        }

    }
}