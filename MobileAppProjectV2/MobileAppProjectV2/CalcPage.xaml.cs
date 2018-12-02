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
        public CalcPage()
        {
            InitializeComponent();
        }
        private void setUpGrid()
        {
            var Grid = new Grid();
            GridSetUp.ColumnDefinitions = new ColumnDefinitionCollection();
            // rows
            GridSetUp.RowDefinitions = new RowDefinitionCollection();
        }
        private void OnSelectNumber(object sender, EventArgs e)
        {

        }
        public static double Calculate(string mathOperator, double value)
        {
            double result = 0;

            switch (mathOperator)
            {
                case "+":
                    result = result + value;
                    break;
                case "-":
                    result = result - value;
                    break;
            }

            return result;
        }

    }
}