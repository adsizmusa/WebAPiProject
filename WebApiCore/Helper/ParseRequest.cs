using BussinessCommon.Helpers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebApiCore.Helper
{
    public class ParseRequest
    {
        public static PageParameters GetParametersFromHeader(HttpContext httpContext)
        {
            var retVal = new PageParameters
            {
                UserName = httpContext.User.FindFirst(ClaimTypes.Name)?.Value
            };




            //if (int.TryParse(httpContext.Request.Headers["CompanyID"].FirstOrDefault(), out int CompanyID))
            //{
            //    retVal.CompanyID = CompanyID;
            //}

            if (int.TryParse(httpContext.Request.Headers["MemberId"].FirstOrDefault(), out int MemberId))
            {
                retVal.MemberId = MemberId;
            }

            //if (int.TryParse(httpContext.Request.Headers["timezoneoffset"].FirstOrDefault(), out int timezoneoffset))
            //{
            //    retVal.TimeZoneOffset = timezoneoffset;
            //}

            //var accessCode = httpContext.Request.Headers["accessCode"].FirstOrDefault();

            //if (!string.IsNullOrEmpty(accessCode))
            //    retVal.AccessCode = accessCode;

            //string debugInfos = httpContext.Request.Headers["DebugInfos"].FirstOrDefault();
            //if (!string.IsNullOrWhiteSpace(debugInfos))
            //    retVal.DebugInfos = debugInfos;

            //string currentLanguage = httpContext.Request.Headers["CurrentLanguage"].FirstOrDefault();
            //if (!string.IsNullOrWhiteSpace(currentLanguage))
            //    retVal.CurrentLanguage = currentLanguage;

            return retVal;
        }
    }
}
