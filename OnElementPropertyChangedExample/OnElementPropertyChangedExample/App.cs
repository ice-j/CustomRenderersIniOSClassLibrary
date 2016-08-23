using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace OnElementPropertyChangedExample
{
    public class App : Application
    {
        public App()
        {
            var customView = new CustomView()
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                HeightRequest = 120,
                WidthRequest = 120
            };
            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new StackLayout()
                        {
                            VerticalOptions = LayoutOptions.FillAndExpand,
                            HorizontalOptions = LayoutOptions.FillAndExpand,
                            Children =
                            {
                                customView,
                                new Button { Text = "Red", Command = new Command(()=>customView.CustomBackgroundColor = Color.Red) },
                                new Button { Text = "Green", Command = new Command(()=>customView.CustomBackgroundColor = Color.Green) },
                                new Button { Text = "Blue", Command = new Command(()=>customView.CustomBackgroundColor = Color.Blue) },
                                new Button { Text = "Clear", Command = new Command(()=>customView.CustomBackgroundColor = Color.Transparent) }
                            }
                        }
                    }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
