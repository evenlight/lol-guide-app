using System;
using System.Collections.Generic;
//using 

using Xamarin.Forms;

namespace MyLoLApp.Views
{
    public partial class GuidesPage : ContentPage
    {
        public GuidesPage()
        {
            InitializeComponent();
        }

        public string Hui()
        {
            HuiLabel.Text = "hui";
            return "hui";
        }

        protected override void OnAppearing()
        {
            Hui();
            //ChampionsPage.OnAppearing(base);
        }
    }
}
