﻿using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace Controls.Sample.Converters
{
	public class NegativeConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is bool v)
				return !v;
			else
				return false;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is bool v)
				return !v;
			else
				return true;
		}
	}
}