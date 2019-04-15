namespace Ayo.API.Resources
{
    public class ConversionChartResource
    {

        public int Id { get; set; }
        public string Metric { get; set; }
        public string Imperial { get; set; }
        public CategoryResource Category { get; set; }
    }
}
