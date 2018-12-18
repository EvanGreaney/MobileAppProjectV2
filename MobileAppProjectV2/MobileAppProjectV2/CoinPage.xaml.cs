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
    public partial class CoinPage : ContentPage
    {
        public CoinPage()
        {
            InitializeComponent();
            
        }



        private void CoinFlipper_Clicked(object sender, EventArgs e)
        {

            //array of strings
            string[] strLabel =
            {
                "0","1",
            };
            //random number generator
            Random r = new Random();
            int NumSelect = r.Next(0,2);
            if (NumSelect == 1)
            {
                CoinImage.Source = ImageSource.FromResource("MobileAppProjectV2.Images.coin_tex_head.png");
            }
            else
            {
                CoinImage.Source = ImageSource.FromResource("MobileAppProjectV2.Images.coin_tex_tail.png");
            }

        }   
    }
}