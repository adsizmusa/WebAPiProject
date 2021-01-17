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
    public class UserLoginRepostiry: BaseRepostiry, IUserLoginRepostiry
    {
        public UserLoginRepostiry(DBContext _dbContext, IMapper _mapper) : base(_dbContext, _mapper)
        {

        }

        public Member GetMember(string username, string password)
        {
        

            var member = _context.Member.FirstOrDefault(s => s.Email == username && s.Password == password);
            if(member != null)
            {
                return member;
            }
            else
            {
                return null;
            }
        }
    }
}
