using BlogMVCProject.Entity.DTOs.Images;
using BlogMVCProject.Entity.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogMVCProject.Service.Helpers.Images
{
	public interface IImageHelper
	{
		Task<ImageUploadedDto> Upload(string name, IFormFile imageFile, ImageType imageType, string folderName = null);
		void Delete(string imageName);
	}
}
