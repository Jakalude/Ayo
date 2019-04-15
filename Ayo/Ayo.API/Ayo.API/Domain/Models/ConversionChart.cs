namespace Ayo.API.Domain.Models
{
    public class ConversionChart
    {
        public int Id { get; set; }
        public string Metric { get; set; }
        public string Imperial { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
