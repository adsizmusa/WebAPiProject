using BussinesLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinesLayer.Entities
{
    public class OrderItem : BaseEntities
    {

        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
