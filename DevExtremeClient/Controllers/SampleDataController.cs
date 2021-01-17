using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace DevExtremeClient.Controllers {

    [Route("api/[controller]")]
    public class SampleDataController : BaseController {
        public SampleDataController(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {

        }
     

    }
}