using AutoMapper;
using BlogMVCProject.Entity.DTOs.Users;
using BlogMVCProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogMVCProject.Service.AutoMapper.Users
{
	public class UserProfile : Profile
	{
		public UserProfile()
		{
			CreateMap<AppUser, UserDto>().ReverseMap();
			CreateMap<AppUser, UserAddDto>().ReverseMap();
			CreateMap<AppUser, UserUpdateDto>().ReverseMap();
			CreateMap<AppUser, UserProfileDto>().ReverseMap();

		}
	}
}
