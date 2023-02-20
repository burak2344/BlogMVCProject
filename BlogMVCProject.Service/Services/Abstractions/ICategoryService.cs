﻿using BlogMVCProject.Entity.DTOs.Categories;
using BlogMVCProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogMVCProject.Service.Services.Abstractions
{
	public interface ICategoryService
	{
		Task<List<CategoryDto>> GetAllCategoriesNonDeleted();
		Task<List<CategoryDto>> GetAllCategoriesDeleted();
		Task CreateCategoryAsync(CategoryAddDto categoryAddDto);
		Task<Category> GetCategoryByGuid(Guid id);
		Task<string> UpdateCategoryAsync(CategoryUpdateDto categoryUpdateDto);
		Task<string> SafeDeleteCategoryAsync(Guid categoryId);
		Task<string> UndoDeleteCategoryAsync(Guid categoryId);
	}
}
