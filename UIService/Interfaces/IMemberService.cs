using BussinessDTO.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace UIService.Interfaces
{
    public interface IMemberService
    {
        AuthResponse GetToken(MemberDTO member);
    }
}
