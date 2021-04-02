using System;
using System.ComponentModel.DataAnnotations;

namespace ProductData.Entity.Dto
{
    public class ProductAttributesDto
    {
        public int ProductAttributeId { get; set; }
        public int ProductId { get; set; }
        public string Color { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }


}
