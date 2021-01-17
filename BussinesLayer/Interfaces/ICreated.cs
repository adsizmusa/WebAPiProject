using System;
using System.Collections.Generic;
using System.Text;

namespace BussinesLayer.Interfaces
{
    public interface ICreated
    {
        DateTime? CreatedDate { get; set; }
        int? CreatedMemberId { get; set; }
    }
}
