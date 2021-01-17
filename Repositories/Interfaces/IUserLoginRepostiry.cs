using BussinesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
   public interface IUserLoginRepostiry
    {
        Member GetMember(string username, string password);
    }
}
