using FFImageLoading.Svg.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDEMO.CustomControl;

namespace XamarinDEMO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DemoSvgPage : ContentPage
    {
        ICommand _svg_command;
        public ICommand SVG_Command
        {
            get { return _svg_command; }
            set { _svg_command = value; }
        }

        public DemoSvgPage()
        {
            InitializeComponent();
            SVG_Command = new Command(SVG_Tapped);
            BindingContext = this;
        }

        void SVG_Tapped(object s)
        {
            //Mostrar Popup
            Debug.WriteLine("[POPUP]");
        }
    }
}