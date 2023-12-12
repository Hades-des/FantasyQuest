using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FantasyQuest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void ButtonStayInTavern_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new End1());
        }

        private async void ButtonGoOnJourney_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Scene2());
        }
    }
}
