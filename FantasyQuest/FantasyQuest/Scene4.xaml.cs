﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FantasyQuest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Scene4 : ContentPage
    {
        public Scene4()
        {
            InitializeComponent();

        }
        private async void ButtonHitSkeleton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new End3());
        }
    }
}