using System;
using System.Collections.Generic;
using System.Text;
using XamarinNavigationTest.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinNavigationTest.ViewModel
{
    class MainVM
    {
        public MainVM()
        {
            ToSecondPage = new Command(ToSecondPageClicekd);

        }

        public Command ToSecondPage { get; set; }
        public async void ToSecondPageClicekd()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SecondPage());
        }
    }
}
