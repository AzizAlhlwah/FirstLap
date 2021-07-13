using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

    
namespace GallaryPro
{
    [DesignTimeVisible(false)]
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            //Car1.Source = ImageSource.FromFile("~/images/001.png");

            //Car1.Source = (Device.RuntimePlatform == Device.Android) ? ImageSource.FromFile("001.png") : ImageSource.FromFile("Images/001.PNG");
            InitializeComponent();

            Car1.Source = ImageSource.FromUri(new Uri("https://pngimage.net/wp-content/uploads/2018/06/sports-car-png-1.png"));
            Car2.Source = ImageSource.FromUri(new Uri("http://pngimg.com/uploads/jeep/jeep_PNG146.png"));
            Car3.Source = ImageSource.FromUri(new Uri("http://pngimg.com/uploads/jeep/jeep_PNG136.png"));
            Car4.Source = ImageSource.FromUri(new Uri("http://pngimg.com/uploads/jeep/jeep_PNG3.png"));

          
        }
    }
}
