using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfApp1.Converts
{
	public class TextLenthToVisibility : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var str = value as string;
			if (str != null)
			{
				if (str.Length > 0)
				{
					return Visibility.Hidden;
				}
				else { return Visibility.Visible; }
			}
			return null;

		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var s = 1;
			throw new NotImplementedException();
		}
	}
}
