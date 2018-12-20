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
	public partial class DicePage : ContentPage
	{
		public DicePage ()
		{
			InitializeComponent ();
		}

        //Dice Roll method that when called generates a random number
        //and depending on the number displays a certain image of a dice
        private void DiceRoller_Clicked(object sender, EventArgs e)
        {
            //random number generator
            Random r = new Random();
            int NumSelect = r.Next(0, 6);
            if (NumSelect == 1)
            {
                DiceImage.Source = ImageSource.FromResource("MobileAppProjectV2.Images.inverted_dice_1.png");
                Result.Text = "One";
            }
            else if (NumSelect == 2)
            {
                DiceImage.Source = ImageSource.FromResource("MobileAppProjectV2.Images.inverted_dice_2.png");
                Result.Text = "Two";
            }
            else if (NumSelect == 3)
            {
                DiceImage.Source = ImageSource.FromResource("MobileAppProjectV2.Images.inverted_dice_3.png");
                Result.Text = "Three";
            }
            else if (NumSelect == 4)
            {
                DiceImage.Source = ImageSource.FromResource("MobileAppProjectV2.Images.inverted_dice_4.png");
                Result.Text = "Four";
            }
            else if (NumSelect == 5)
            {
                DiceImage.Source = ImageSource.FromResource("MobileAppProjectV2.Images.inverted_dice_5.png");
                Result.Text = "Five";
            }
            else if (NumSelect == 6)
            {
                DiceImage.Source = ImageSource.FromResource("MobileAppProjectV2.Images.inverted_dice_6.png");
                Result.Text = "Six";
            }
            else
            {
                DiceImage.Source = ImageSource.FromResource("MobileAppProjectV2.Images.inverted_dice_6.png");
                Result.Text = "Six";

            }
        }
    }
}