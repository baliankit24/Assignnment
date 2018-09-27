using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }


        [MaxLength(200)]
        public string ManufacturerName { get; set; }


        [MaxLength(10)]
        public string StockSymbol { get; set; }

        public string Mfr { get; set; }
    }
}