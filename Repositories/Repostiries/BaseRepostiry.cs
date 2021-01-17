using AutoMapper;
using BussinesLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Repostiries
{
    public class BaseRepostiry
    {
		public DBContext _context;
		public IMapper mapper;
		public BaseRepostiry(DBContext _dbContext, IMapper _mapper)
		{
			_context = _dbContext;
			mapper = _mapper;
		}
	}
}
