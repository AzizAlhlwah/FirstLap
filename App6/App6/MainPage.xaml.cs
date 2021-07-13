using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            address.Text = Lang.Resource.address;
            screen.Text = Lang.Resource.screen;
            send.Text = Lang.Resource.send;
            Myname.Text = Lang.Resource.Myname;
            name.Text = Lang.Resource.name;
            screen.Text = Lang.Resource.screen;
            show.Text = Lang.Resource.Show;
        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{

        //    screen.Text = Lang.Resource.screen;
        //}
    }
}
