using BussinessDTO.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using UIService.BaseProxy;

namespace UIService.Services
{
    public class BaseService
    {
        public AutProxy autProxy => new AutProxy(_authResponse);
         AuthResponse _authResponse { get; set; }
        public BaseService(AuthResponse authResponse)
        {
        _authResponse = authResponse;
        }
    
    }
}
