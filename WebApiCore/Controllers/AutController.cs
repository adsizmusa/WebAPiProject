using AutoMapper;
using BussinesLayer.Contexts;
using BussinessDTO.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCore.Model;

namespace WebApiCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutController : BaseController
    {
        public IMemberService memberService => new MemberService(context, mapper);
        public AutController(DBContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(context, mapper, httpContextAccessor)
        {

        }

        [HttpPost("GetToken")]
        public IActionResult GetToken( [FromBody] MemberDTO memberDTO)
        {
            var member = memberService.GetMember(memberDTO.Email, memberDTO.Password);



            if (member != null)
            {

                var createToken = HBAuthManager.GenerateToken(member.Firstname.ToString(), member.Id);
                var response = new AuthResponse
                {
                    IsSuccess = true,
                    Token = createToken,
                    MemberId = member.Id,
                    ExpiresOn = DateTime.UtcNow.AddDays(30),
                    Message = "mesegge",
                    ShowInfoBox = true
                };


                return Ok(response);
            }

            return Unauthorized();
        }
    }
}
