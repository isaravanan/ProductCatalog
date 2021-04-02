using System;
using System.ComponentModel.DataAnnotations;

namespace ProductData.Entity
{
    public class Product : BaseEntity
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public double PricePerItem { get; set; }
        public double AverageCustomerRating { get; set; }
    }

  

}
