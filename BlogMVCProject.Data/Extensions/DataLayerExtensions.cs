using BlogMVCProject.Data.Context;
using BlogMVCProject.Data.Repositories.Abstractions;
using BlogMVCProject.Data.Repositories.Concretes;
using BlogMVCProject.Data.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogMVCProject.Data.Extensions
{
	public static class DataLayerExtensions
	{
		public static IServiceCollection LoadDataLayerExtensions(this IServiceCollection services,IConfiguration config)
		{
			services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
			services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));
			services.AddScoped<IUnitOfWork,UnitOfWork>();
			return services;
		}
	}
}
