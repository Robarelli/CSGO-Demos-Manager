using System;
using System.Windows.Controls;

namespace Manager.Models.Formatters
{
	public class CustomSecondsFormatter : UserControl, IIntervalFormatterProvider
	{
		public Func<DateTime, string>[] GetFormatters(IntervalBase interval)
		{
			return new Func<DateTime, string>[]
			{
				date => date.ToString("mm:ss")
			};
		}

		public Func<DateTime, string>[] GetIntervalSpanFormatters(IntervalBase interval)
		{
			return new Func<DateTime, string>[]
			{
				date => date.ToString("mm:ss")
			};
		}
	}
}
