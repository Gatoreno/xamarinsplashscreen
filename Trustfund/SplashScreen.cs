﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Trustfund
{
    class SplashScreen : ContentPage 
    {
        Image splashImage;
        


        public SplashScreen()
        {
            NavigationPage.SetHasNavigationBar(this,false);

            var sub = new AbsoluteLayout();
            splashImage = new Image{
                Source="iko.png",
                WidthRequest=150,
                HeightRequest=150,
                Opacity=0
            };

            AbsoluteLayout.SetLayoutFlags(splashImage,
                 AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage,
             new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);

            this.BackgroundColor = Color.FromHex("#FFFFFF");
            this.Content = sub;
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();


            await splashImage.FadeTo(1, 150, null);
            await splashImage.ScaleTo(1, 1000); //Time-consuming processes such as initialization
            await splashImage.ScaleTo(0.6, 1500, Easing.BounceOut);
            await splashImage.FadeTo(0,270,null);


            Application.Current.MainPage = new NavigationPage(new MainPage());

        }

    }


}
