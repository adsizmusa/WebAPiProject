using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BussinessDTO.DTOs;
using UIService.BaseProxy;
using UIService.Services;
using Microsoft.AspNetCore.Http;
using UIService.Interfaces;

namespace DevExtremeClient.Controllers
{
    public class LoginController : BaseController
    {
        IMemberService memberServices => new MemberService(authResponse);

 
        public LoginController(IHttpContextAccessor httpContextAccessor):base(httpContextAccessor)
        {

        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Login(MemberDTO member)
        {
            var response = memberServices.GetToken(member);
          
            return Json(response);
        }
    }
}