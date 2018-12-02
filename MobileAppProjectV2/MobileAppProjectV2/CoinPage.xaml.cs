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
            Coinflip();
        }
        private static int Coinflip()
        {

            Random Rand = new Random();

            int heads = 0;
            int tails = 0;
            int result = 0;
            int coinAmount = 3;

            for (int i = 0; i < coinAmount; i++)
            {
                result = Rand.Next(0, 2);
                if (result == 1)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
                
            }
            return result;
        }
    }
}