using BussinessDTO.DTOs;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UIService.Interfaces;
using UIService.Services;

namespace DevExtremeClient.Controllers
{
    public class HomeController : BaseController
    {
        IOrderService orderService => new OrderService(authResponse);
        public HomeController(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {

        }

        [HttpPost]
        public JsonResult SaveOrder(OrderDTO order)
        {
            var response = orderService.SaveOrder(order);
            return Json(response);
        }

        [HttpGet]
        public object GetOrders(DataSourceLoadOptions loadOptions)
        {
            var data = orderService.GetOrders();
            return DataSourceLoader.Load(data, loadOptions);
        }
    }
}
