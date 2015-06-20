using System;
using System.Collections.Generic;

using Xamarin.Forms;
using ParseSample.ViewModels;

namespace ParseSample.Pages
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
            BindingContext = new SignUpViewModel();
        }
    }
}

