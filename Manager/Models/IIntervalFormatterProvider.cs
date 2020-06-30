using System;

namespace Manager.Models
{
    public interface IIntervalFormatterProvider
    {
        Func<DateTime, string>[] GetIntervalSpanFormatters(IntervalBase interval);
    }
}
