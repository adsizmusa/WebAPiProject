using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using BussinessDTO.DTOs;

namespace DevExtremeClient.Controllers
{
    public class BaseController : Controller
    {
        private static IHttpContextAccessor _accessor;
        public static HttpContext _httpContext => _accessor.HttpContext;
        public  AuthResponse authResponse { get; set; }
        public BaseController(IHttpContextAccessor httpContextAccessor)
        {
            _accessor = httpContextAccessor;
            AuthResponse _authResponse = new AuthResponse();
            try
            {
        
                _authResponse.Token = _httpContext.Request.Cookies["token"];
                if(_httpContext.Request.Cookies["memberId"]!= null)
                {
                    _authResponse.MemberId = int.Parse(_httpContext.Request.Cookies["memberId"].ToString());
                }
                else
                {
                    _authResponse.MemberId = 0;
                }
              
            }
            catch (Exception)
            {
                _authResponse.Token = null;
                _authResponse.MemberId = 0;
            }
            authResponse = _authResponse;
        }

    }
}
