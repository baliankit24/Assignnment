using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class Product
    {
        public string ProductId { get; set; }
        public string name { get; set; }
        public string mfr { get; set; }
        public string type { get; set; }
        public string calories { get; set; }
        public string protein { get; set; }
        public string fat { get; set; }
        public string sodium { get; set; }
        public string fiber { get; set; }
        public string carbo { get; set; }
        public string sugars { get; set; }
        public string potass { get; set; }
        public string vitamins { get; set; }
        public string shelf { get; set; }
        public string weight { get; set; }
        public string cups { get; set; }
        public string rating { get; set; }

    }
}