using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessDTO.DTOs
{
   public  class OrderItemDTO:BaseDTO
    {
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
