using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FantasyQuest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Scene2 : ContentPage
    {
        public Scene2()
        {
            InitializeComponent();
        }
        private async void ButtonReturnToTavern_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new End1());
        }

        private async void ButtonOpenMap_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Scene3());
        }
    }
}