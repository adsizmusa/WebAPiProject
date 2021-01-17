using AutoMapper;
using BussinesLayer.Contexts;
using BussinesLayer.Entities;
using BussinessDTO.DTOs;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Repostiries
{
    public class OrderRepostry:BaseRepostiry,IOrderRepostry
    {
        public OrderRepostry(DBContext _dbContext, IMapper _mapper) : base(_dbContext, _mapper)
        {

        }

        public List<OrderDTO> GetOrders()
        {

            var orders = _context.Order.ToList();

            var result = mapper.Map<List<OrderDTO>>(orders);

            return result;
        }

        public bool SaveOrder(OrderDTO order)
        {
            var orderEntitiy = mapper.Map<Order>(order);

            orderEntitiy.MemberId = _context.BaseParameters.MemberId;
            orderEntitiy.CreatedMemberId = _context.BaseParameters.MemberId;
            orderEntitiy.CreatedDate = DateTime.Now;
            _context.Order.Add(orderEntitiy);
            _context.SaveChanges();
            foreach (var item in order.OrderItems)
            {
                var orderItemEntitiy = mapper.Map<OrderItem>(item);
                orderItemEntitiy.CreatedMemberId = _context.BaseParameters.MemberId;
                orderItemEntitiy.OrderId = orderEntitiy.Id;
                orderItemEntitiy.CreatedDate = DateTime.Now;
                orderItemEntitiy.ProductId = 5;
                _context.OrderItem.Add(orderItemEntitiy);
            }
            return true;
        }
    }
}
