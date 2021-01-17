using BussinessDTO.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UIService.Interfaces;

namespace UIService.Services
{
   public class MemberService: BaseService, IMemberService
    {
        public MemberService(AuthResponse _authResponse) :base(_authResponse)
        {

        }
        public AuthResponse GetToken(MemberDTO member)
        {
            AuthResponse response = new AuthResponse();
            Task.Run(() =>
            {
                try
                {
                    response = autProxy.GetToken(member);
                }
                catch (Exception ex)
                {
                    response = new AuthResponse
                        {
                    IsSuccess = false,
                    Message = ex.Message,
                    
                    
                    };


                }
               
            }).Wait();

            return response;
        }
    }
}
