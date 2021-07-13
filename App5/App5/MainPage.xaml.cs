using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Essentials;
using Plugin.Share;


namespace App5
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void PlacePhoneCall(object o, EventArgs e)
        {
            try
            {
                PhoneDialer.Open(phoneNumber.Text);
            }
            catch (ArgumentNullException anEx)
            {
                Console.WriteLine(anEx.Message);
                // Number was null or white space
            }
            catch (FeatureNotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
                // Phone Dialer is not supported on this device.
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Other error has occurred.
            }
            finally { }
        }
        async void OpenWeb(object o, EventArgs e)
        {
            await CrossShare.Current.OpenBrowser("http://www.google.com");
        }
        async void RotateLabel(object o, EventArgs e)
        {
            await label.RelRotateTo(360, 1000);
        }
        async void Button_OnClicked(object sender, EventArgs e)
        {
            switch (((Button)sender).StyleId)
            {
                case "Call":
                    try
                    {
                        PhoneDialer.Open(phoneNumber.Text);
                    }
                    catch (ArgumentNullException anEx)
                    {
                        Console.WriteLine(anEx.Message);
                    }
                    catch (FeatureNotSupportedException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "Rotate":
                    await label.RelRotateTo(360, 1000);
                    break;
                case "Web":
                    await CrossShare.Current.OpenBrowser("http://www.Xamarin.com");
                    break;
            }
        }
    }
}
