using FFImageLoading.Svg.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDEMO.CustomControl;

namespace XamarinDEMO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DemoSvgPage : ContentPage
    {
        public DemoSvgPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        void SVG_Tapped(object sender, EventArgs e)
        {
            SVGCustom svg = sender as SVGCustom;
            svg.ChangeColor(svg.Color2);
        }
    }
}