using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessDTO.DTOs
{
    public class AuthResponse
    {
        public bool IsSuccess { get; set; }
        public string Token { get; set; }
        public int MemberId { get; set; }
        public DateTime ExpiresOn { get; set; }

        public string Message { get; set; }
        public bool ShowInfoBox { get; set; }
    }
}
