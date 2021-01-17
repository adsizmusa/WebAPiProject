using BussinessDTO.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace UIService.Interfaces
{
    public interface IOrderService
    {
        DefaultResponse SaveOrder(OrderDTO data);
        List<OrderDTO> GetOrders();
    }
}
