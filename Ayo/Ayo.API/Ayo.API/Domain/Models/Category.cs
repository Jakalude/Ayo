using System.Collections.Generic;

namespace Ayo.API.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<ConversionChart> ConversionChart { get; set; } = new List<ConversionChart>();
    }
}
