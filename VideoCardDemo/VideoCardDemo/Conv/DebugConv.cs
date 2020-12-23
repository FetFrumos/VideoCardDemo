using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using TiqsVendor.Core.VideoPlayer;
using Xamarin.Forms;

namespace VideoCardDemo.Conv
{
    public class DebugConv :IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                string curr = value.ToString();
                if (!String.IsNullOrEmpty(curr))
                {
                    var res = new ResourceVideoSource {Path = curr};
                    return res;
                }
                else
                {
                    return value;
                }
            }
            else
            {
                return value;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
