﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistaShop.Catalog.Dtos.CategoryDtos;
using RegistaShop.Catalog.Services.CategoryServices;

namespace RegistaShop.Catalog.Controllers
{
	
	public class CategoriesController : ApiBaseController
	{

		private readonly ICategoryService _categoryService;

		public CategoriesController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		[HttpGet]
		public async Task<IActionResult> CategoryList()
		{

			var values = await _categoryService.GetAllCategoryAsync();
			return Ok(values);

		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetCategoryById(string id)
		{

			var values = await _categoryService.GetByIdCategoryAsync(id);
			return Ok(values);

		}

		[HttpPost]
		public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
		{

			await _categoryService.CreateCategoryAsync(createCategoryDto);
			return Ok("Kategori başarıyla eklendi.");

		}

		[HttpDelete]
		public async Task<IActionResult> DeleteCategory(string id)
		{
			await _categoryService.DeleteCategoryAsync(id);
			return Ok("Kategori başarıyla silindi");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
		{

			await _categoryService.UpdateCategoryAsync(updateCategoryDto);
			return Ok("Kategori başarıyla güncellendi.");

		}
	}
}