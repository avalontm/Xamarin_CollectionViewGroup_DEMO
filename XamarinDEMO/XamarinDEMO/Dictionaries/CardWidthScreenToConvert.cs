using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinDEMO.Dictionaries
{
    public class CardWidthScreenToConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DeviceDisplay.MainDisplayInfo.Width - 60;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
