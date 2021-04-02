using System;
using System.ComponentModel.DataAnnotations;

namespace ProductData.Entity.Dto
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public float PricePerItem { get; set; }
        public float AverageCustomerRating { get; set; }
    }
}
