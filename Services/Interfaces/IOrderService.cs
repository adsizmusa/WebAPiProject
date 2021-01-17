using BussinessDTO.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IOrderService
    {
        bool SaveOrder(OrderDTO data);
        List<OrderDTO> GetOrders();
    }
}
