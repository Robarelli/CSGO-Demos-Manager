using System;
using System.Windows;

namespace Manager.Models
{
    public class TimelineDataItem : DataPointItemBase
    {
        public TimeSpan Duration { get; }
        public string DurationPath { get; set; }
        public object Group { get; }
        public string GroupPath { get; set; }
        public bool IsSelected { get; set; }
        public DateTime Start { get; }
        public string StartPath { get; set; }
        public long Ticks { get; }
        public object ToolTip { get; }
        public bool ToolTipAvailable { get; }
        public string ToolTipFormat { get; set; }
        public string ToolTipPath { get; set; }
        public DataTemplate ToolTipTemplate { get; set; }
    }
}
