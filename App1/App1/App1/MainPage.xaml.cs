﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        async private void Intro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IntroPage());
        }

        private void Step_1_Clicked(object sender, EventArgs e)
        {

        }

        private void Step_2_Clicked(object sender, EventArgs e)
        {

        }
    }
}
