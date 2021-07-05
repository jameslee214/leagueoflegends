﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace Leagueoflegends.Converter
{
	public class StatusConverter : MarkupExtension, IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return int.Parse(value.ToString()) switch
			{
				1 => "In Game",
				2 => "Champ Select",
				3 => "League+",
				4 => "Away",
				_ => "Offline"
			};
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		public override object ProvideValue(IServiceProvider serviceProvider)
		{
			return this;
		}
	}
}
