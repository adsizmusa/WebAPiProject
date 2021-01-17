using BussinessDTO.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using UIService.Interfaces;

namespace UIService.Services
{
   public class OrderService: BaseService, IOrderService
    {
        public OrderService(AuthResponse _authResponse) : base(_authResponse)
        {

        }

        public DefaultResponse SaveOrder(OrderDTO order)
        {
            return autProxy.SaveOrder(order);
        }
        public List<OrderDTO> GetOrders()
        {
            return autProxy.GetOrders();
        }
    }
}
