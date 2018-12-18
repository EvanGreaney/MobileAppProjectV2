using System;
using System.Collections.Generic;
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
        int currentState = 1;
        string myoperator;
        int mainNumber1, mainNumber2;
        int resultNumber1, resultNumber2;

        public CalcPage()
        {
           
            InitializeComponent();
            resultNumber1 = Convert.ToInt32(resultText.Text);
            resultNumber2 = Convert.ToInt32(resultText2.Text);
            
        }
        private void setUpGrid()
        {
            var Grid = new Grid();
            GridSetUp.ColumnDefinitions = new ColumnDefinitionCollection();
            // rows
            GridSetUp.RowDefinitions = new RowDefinitionCollection();
        }
       
        void OnSelectNumberRed(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int numberPressed = 0;
            numberPressed = Convert.ToInt32(button.Text);
            mainNumber1 = numberPressed;
        }

        void OnSelectNumberBlue(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int numberPressed = 0;
            numberPressed = Convert.ToInt32(button.Text);
            mainNumber2 = numberPressed;
        }
        void OnSelectOperaterRed(object sender, EventArgs e)//event is called when the select operator is called 
        {
            
            Button button = (Button)sender;
            string pressed = button.Text;
            myoperator = pressed;
        }

        void OnSelectOperaterBlue(object sender, EventArgs e)//event is called when the select operator is called 
        {

            Button button = (Button)sender;
            string pressed = button.Text;
            myoperator = pressed;
        }


        void OnCalculateBlue(object sender, EventArgs e) //This method is called when we have both first number and second number and we are going to evaluate those number
        {
            var result = 0;
            result = 0;
                 result = OperatorHelper.Calculate(mainNumber2, resultNumber2, myoperator);
                String stringresult = Convert.ToString(result);
                resultText.Text = stringresult;
            
        }

        void OnCalculateRed(object sender, EventArgs e) //This method is called when we have both first number and second number and we are going to evaluate those number
        {
            var result = 0;
            result = 0;  
                 result = OperatorHelper.Calculate(mainNumber1, resultNumber1, myoperator);
                String stringresult = Convert.ToString(result);
                resultText2.Text = stringresult;
                
                
            
        }

    }
}