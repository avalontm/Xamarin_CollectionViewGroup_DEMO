using FFImageLoading.Svg.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace XamarinDEMO.CustomControl
{
    public class SVGCustom : SvgCachedImage
    {
        public static readonly BindableProperty Color1Property = BindableProperty.Create(nameof(Color1), typeof(string), typeof(SVGCustom), default(string), BindingMode.OneWay);
        public string Color1
        {
            get
            {
                return (string)GetValue(Color1Property);
            }

            set
            {
                SetValue(Color1Property, value);
            }
        }

        public static readonly BindableProperty Color2Property = BindableProperty.Create(nameof(Color2), typeof(string), typeof(SVGCustom), default(string), BindingMode.OneWay);
        public string Color2
        {
            get
            {
                return (string)GetValue(Color2Property);
            }

            set
            {
                SetValue(Color2Property, value);
            }
        }

        public static readonly BindableProperty FileProperty = BindableProperty.Create(nameof(File), typeof(string), typeof(SVGCustom), default(string), BindingMode.OneWay);
        public string File
        {
            get
            {
                return (string)GetValue(FileProperty);
            }

            set
            {
                SetValue(FileProperty, value);
            }
        }

        public SVGCustom()
        {

        }

        protected override void OnParentSet()
        {
            base.OnParentSet();
            onChangeColor(Color1);
        }

        public void ChangeColor(string color)
        {
            onChangeColor(color);
        }

        void onChangeColor(string color)
        {
            var dict = new Dictionary<string, string>();
            dict.Add("fill=\"heart_filled\"", "fill=\"" + color + "\"");
            dict.Add("opacity=\"heart_filled\"", "opacity=\"1\"");

            Source = SvgImageSource.FromFile(File, replaceStringMap: dict);
            Debug.WriteLine($"[onChangeColor] {color}");
        }
    }
}
