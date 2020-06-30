namespace Manager.Models
{
    public class CategoricalDataPoint : DataPointItemBase
    {
        public string Category { get; set; }
        public double Value { get; set; }
        public string Label { get; set; }
    }
}
