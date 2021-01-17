using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessCommon.Helpers
{
    public class PageParameters
    {
        public string UserName { get; set; }
        public int CompanyID { get; set; }
        public int TimeZoneOffset { get; set; }
        public int? PageSize { get; set; }
        public int? PageID { get; set; }
        public string AccessCode { get; set; }
        public string DebugInfos { get; set; }
        public string CurrentLanguage { get; set; }
        public int MemberId { get; set; }
        public bool IsMobileClient { get; set; }

        public int? GuestID { get; set; }
    }
}
