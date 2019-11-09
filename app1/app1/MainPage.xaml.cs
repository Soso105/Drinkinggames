using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace app1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        async void Game1(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Game1());
		  
        }
        async void Game2(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Game2());
        }
        async void Game3(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Game3());

        }
        async void Game4(object sender , EventArgs args)
        {
            await Navigation.PushAsync(new Game4());
        }
    }
}