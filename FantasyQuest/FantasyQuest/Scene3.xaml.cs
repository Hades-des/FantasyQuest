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
    public partial class Scene3 : ContentPage
    {
        public Scene3()
        {
            InitializeComponent();
        }
        private async void ButtonStayInForest_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new End2());
        }

        private async void ButtonEnterCave_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Scene4());
        }
    }
}