using AutoMapper;
using BussinesLayer.Contexts;
using BussinesLayer.Entities;
using BussinessDTO.DTOs;
using Repositories.Interfaces;
using Repositories.Repostiries;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class MemberService : BaseService, IMemberService
    {
        public IUserLoginRepostiry userLoginRepostiry => new UserLoginRepostiry(context, mapper);
        public MemberService(DBContext _dbContext, IMapper _mapper) : base(_dbContext, _mapper)
        {

        }
        public MemberDTO GetMember(string username, string password)
        {
            var member = userLoginRepostiry.GetMember(username, password);
            
            if(member !=null)
            {
                return mapper.Map<MemberDTO>(member);
            }
            else
            {
                return null;
            }
           
        }
    }
}
