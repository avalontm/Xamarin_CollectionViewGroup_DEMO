using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace XamarinDEMO.Sources
{
    public static class ScreenManager
    {
        public static double Width 
        { 
            get {  return DeviceDisplay.MainDisplayInfo.Width - 60;  } 
        }
    }
}
