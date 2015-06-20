using System;

using Xamarin.Forms;
using Parse;

namespace ParseSample
{
    public class App : Application
    {
        public App()
        {

            ParseClient.Initialize(Helpers.Keys.ParseAppKey, Helpers.Keys.ParseDotNetKey);

            // The root page of your application
            MainPage = new NavigationPage(new Pages.SignUpPage());
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

