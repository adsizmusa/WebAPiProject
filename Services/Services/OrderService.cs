using AutoMapper;
using BussinesLayer.Contexts;
using BussinessDTO.DTOs;
using Repositories.Interfaces;
using Repositories.Repostiries;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class OrderService:BaseService,IOrderService
    {
        public IOrderRepostry orderRepostry => new OrderRepostry(context, mapper);
        public OrderService(DBContext _dbContext, IMapper _mapper) : base(_dbContext, _mapper)
        {

        }
        public bool SaveOrder(OrderDTO order)
        {
            return orderRepostry.SaveOrder(order);
        }

        public List<OrderDTO> GetOrders()
        {
            return orderRepostry.GetOrders();
        }
    }
}
