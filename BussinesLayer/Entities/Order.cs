using BussinesLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinesLayer.Entities
{
    public class Order: BaseEntities
    {
        public Order()
        {
            OrderItem = new HashSet<OrderItem>();
        }
        public decimal Amount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal GeneralAmount { get; set; }
        public decimal ShippingAmount { get; set; }
        public decimal FinalAmount { get; set; }
        public int  OrderStatus { get; set; }
        public int PaymentStatus { get; set; }
        public int MemberId { get; set; }
        public ICollection<OrderItem> OrderItem { get; set; }
    }
}
