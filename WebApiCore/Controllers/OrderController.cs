using AutoMapper;
using BussinesLayer.Contexts;
using BussinessDTO.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Controllers
{
    [Authorize("Bearer")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : BaseController
    {
        public IOrderService orderService => new OrderService(context, mapper);
        public OrderController(DBContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(context, mapper, httpContextAccessor)
        {

        }
        [HttpPost("SaveOrder")]
        public IActionResult SaveOrder([FromBody] OrderDTO order)
        {
            DefaultResponse response = new DefaultResponse();
            try
            {
                var result = orderService.SaveOrder(order);
                context.SaveChanges();
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Messegges = ex.Message;

            }


            return Ok(response);
        }
        [HttpGet("GetOrders")]
        public IActionResult GetOrders()
        {
            var result = orderService.GetOrders();
            return Ok(result);
        }
    }
}
