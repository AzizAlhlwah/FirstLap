using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GallaryPro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarsGallary : CarouselPage
    {
        public CarsGallary()
        {
            InitializeComponent();
            //car1.source = imagesource.fromuri(new uri("https://pngimage.net/wp-content/uploads/2018/06/sports-car-png-1.png"));
            //car2.source = imagesource.fromuri(new uri("http://pngimg.com/uploads/jeep/jeep_png146.png"));
            //car3.source = imagesource.fromuri(new uri("http://pngimg.com/uploads/jeep/jeep_png136.png"));
            //car4.source = imagesource.fromuri(new uri("http://pngimg.com/uploads/jeep/jeep_png3.png"));
        }
    }
}