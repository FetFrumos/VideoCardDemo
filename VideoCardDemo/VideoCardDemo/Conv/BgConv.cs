using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace VideoCardDemo.Conv
{
    public class BgConv : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int id)
            {
                switch (id)
                {
                    case 0:
                        return Color.Aqua;
                    case 1:
                        return Color.Bisque;
                    case 2:
                        return Color.Red;
                    case 3:
                        return Color.Green;
                    case 4:
                        return Color.Brown;
                    case 5:
                        return Color.Purple;
                    default:
                        return Color.Transparent;
                }
            }
            else
            {
                return Color.Transparent;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
