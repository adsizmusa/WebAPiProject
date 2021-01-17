using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessDTO.DTOs
{
    public class MemberDTO:BaseDTO
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Birthdate { get; set; }
        public string PhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string Address { get; set; }
        public string TcId { get; set; }
    }
}
