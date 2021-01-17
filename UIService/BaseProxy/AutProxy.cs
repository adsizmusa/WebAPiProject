using BussinessDTO.DTOs;
using RestAPI.Envorment;
using RestAPI.RestApi;
using System;
using System.Collections.Generic;
using System.Text;

namespace UIService.BaseProxy
{
    public class AutProxy : RequestRestApi
    {
     
       public AutProxy(AuthResponse authResponse)
        {
            _authResponse = authResponse;
        }
        public AuthResponse GetToken(MemberDTO data)
        {
            return Post<AuthResponse, MemberDTO>(Envorment.GetToken, data);
        }
        public DefaultResponse SaveOrder(OrderDTO data)
        {
            return Post<DefaultResponse, OrderDTO>(Envorment.SaveOrder, data);
        }

        public List<OrderDTO> GetOrders()
        {
            return Get<List<OrderDTO>>(Envorment.GetOrders, "");
        }
    }
}
