using System;
using System.ComponentModel.DataAnnotations;

namespace ProductData.Entity
{
    public class ProductAttribute : BaseEntity
    {
        [Key]
        public int ProductAttributeId { get; set; }
        [Required]
        public int ProductId { get; set; }
        public string Color { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }


}
