using BussinessDTO.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
   public  interface IOrderRepostry
    {
        bool SaveOrder(OrderDTO data);
        List<OrderDTO> GetOrders();
    }
}
