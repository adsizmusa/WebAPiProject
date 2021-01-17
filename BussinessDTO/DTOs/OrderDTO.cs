using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessDTO.DTOs
{
    public class OrderDTO : BaseDTO
    {
        public decimal Amount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal GeneralAmount { get; set; }
        public decimal ShippingAmount { get; set; }
        public decimal FinalAmount { get; set; }
        public int OrderStatus { get; set; }
        public int PaymentStatus { get; set; }
        public int MemberId { get; set; }
        public List<OrderItemDTO> OrderItems { get; set; } = new List<OrderItemDTO>();
    }
}
