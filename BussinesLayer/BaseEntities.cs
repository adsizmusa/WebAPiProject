using BussinesLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinesLayer
{
   public class BaseEntities: ICreated, IModifed
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedMemberId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedMemberId { get; set; }
    }
}
