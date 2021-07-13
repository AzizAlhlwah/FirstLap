using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Felipecsl.GifImageViewLib;

namespace SplashScreen.Droid
{
    [Activity(
        Label = "SplashScreen",
        Icon ="@mipmap/icon",
        MainLauncher =true,
        Theme ="@style/splashTheme",
        NoHistory =true,
        ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize | 
        Android.Content.PM.ConfigChanges.Orientation)]

    public class SplashScreen : AppCompatActivity
    {
        //private GifImageView gifImageView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
          
            // Create your application here

            
        }
    }
}