using System;
using System.Windows.Input;
using MyLoLApp.ViewModels;
using Xamarin.Forms;

namespace MyLoLApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Гайды";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}