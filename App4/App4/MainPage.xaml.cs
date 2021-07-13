using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            MySwitch.Toggled += (s, e) => {
                if (e.Value)
                    BackgroundColor = Color.White;
                else BackgroundColor = Color.Black;
            };

        }
    }
}
