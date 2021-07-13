using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // move.Clicked += (s, e) => Navigation.PushAsync(new NextPage());

            move.Clicked += (s, e) => changecolor();

           // move.Clicked += (s, e) => new NavigationPage(new NextPage());

            //move.Clicked += (s,e) => Application.Current.MainPage.Navigation.PushAsync(new NextPage());

            //Navigation.PushAsync(new NextPage());

        }

        public void changecolor()
        {
            Navigation.PushModalAsync(new NextPage(name.Text));

            //move.Text = "Chaneget";
        }
    }
}
