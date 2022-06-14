using System;
using System.Collections.Generic;
using System.Text;
using XamarinNavigationTest.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinNavigationTest.ViewModel
{
    class SecondVM
    {
        public SecondVM()
        {
            ToThirdPage = new Command(ToThirdPageClicekd);
        }
        public Command ToThirdPage { get; set; }
        public async void ToThirdPageClicekd()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ThirdPage());
        }
    }
}
