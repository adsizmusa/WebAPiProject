using AutoMapper;
using BussinesLayer.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
	public class BaseService
	{
		public DBContext context;
		public IMapper mapper;
		public BaseService(DBContext _dbContext, IMapper _mapper)
		{
			context = _dbContext;
			mapper = _mapper;
		}

        [Obsolete]
        public async Task<IEnumerable<T>> ExcecSP<T>(string functionName, string parameter) where T : class
		{
			return await context.Query<T>().AsNoTracking().FromSql(string.Format("EXEC {0} {1}", functionName, parameter)).ToListAsync();
		}
	}
}
