using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace HelloXamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnFormPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new FormPage()));
        }

        private async void OnListPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new ListViewPage()));
        }
    }
}
