using System;
using System.Windows.Controls;

namespace Manager.Models.Formatters
{
	public class DemoMovieIntervalFormatter : UserControl, IIntervalFormatterProvider
	{
		public Func<DateTime, string>[] GetFormatters(IntervalBase interval)
		{
			return new Func<DateTime, string>[]
			{
				date => $"{date:mm} min"
			};
		}

		public Func<DateTime, string>[] GetIntervalSpanFormatters(IntervalBase interval)
		{
			return new Func<DateTime, string>[]
			{
				date => $"{date:mm} min"
			};
		}
	}
}
