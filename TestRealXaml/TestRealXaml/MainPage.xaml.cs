using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestRealXaml
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    //[AdMaiora.RealXaml.Client.MainPage]
    [AdMaiora.RealXaml.Client.RootPage]
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            AdMaiora.RealXaml.Client.AppManager.Init(this);
            InitializeComponent();
        }

        //private async void HelloButton_Clicked(object sender, EventArgs e)
        //{
        //    await DisplayAlert("Hello World", "This is the first version of RealXaml 4", "Great");
        //}
    }
}
