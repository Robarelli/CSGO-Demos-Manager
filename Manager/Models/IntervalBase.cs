using System;
using System.Windows;

namespace Manager.Models
{
    public abstract class IntervalBase
    {
        public static readonly DependencyProperty CurrentIntervalSpanProperty;

        public static readonly DependencyProperty IntervalSpansProperty;


        public int CurrentIntervalSpan { get; }

        public IIntervalFormatterProvider FormatterProvider { get; set; }
        public abstract Func<DateTime, string>[] Formatters { get; }
        public virtual Func<DateTime, string>[] IntervalSpanFormatters { get; }
        public IntervalSpanCollection IntervalSpans { get; set; }
        public abstract TimeSpan MinimumPeriodLength { get; }

    }
}
