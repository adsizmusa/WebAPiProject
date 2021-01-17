using BussinesLayer.Entities;
using BussinessDTO.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
   public interface IMemberService
    {
        MemberDTO GetMember(string username, string password);
    }
}
