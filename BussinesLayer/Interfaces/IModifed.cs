using System;
using System.Collections.Generic;
using System.Text;

namespace BussinesLayer.Interfaces
{
    public interface IModifed
    {
        DateTime? ModifiedDate { get; set; }
        int? ModifiedMemberId { get; set; }
    }
}
