using AutoMapper;
using BussinesLayer.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCore.Helper;

namespace WebApiCore.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class BaseController : ControllerBase
	{
		public DBContext context;
		public readonly IMapper mapper;

	
		//public IUserPermissionService userPermissionService => new UserPermissionService(context, mapper);
		//public ISmsTemplateService smsTemplateService => new SmsTemplateService(context, mapper);
		//public ISmsOptionService smsOptionService => new SmsOptionService(context, mapper);
		//public IServicesService servicesService => new ServiceService(context, mapper);
		//public IServiceLocationService serviceLocationService => new ServiceLocationService(context, mapper);
		//public ICustomerService customerService => new CustomerService(context, mapper);
		//public ICompanyService companyService => new CompanyService(context, mapper);
		//public IAppointmentService appointmentService => new AppointmentService(context, mapper);
		//public IOrderFormService orderFormService => new OrderFormService(context, mapper);

		public BaseController(DBContext _context, IMapper _mapper,  IHttpContextAccessor httpContextAccessor)
		{
			_context.BaseParameters = ParseRequest.GetParametersFromHeader(httpContextAccessor.HttpContext);
			context = _context;
			mapper = _mapper;
		}
	}
}