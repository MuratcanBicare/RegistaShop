﻿using RegistaShop.Catalog.Dtos.ProductDtos;

namespace RegistaShop.Catalog.Services.ProductServices
{
	public interface IProductService
	{

		Task<List<ResultProductDto>> GetAllProductsAsync();

		Task CreateProductAsync(CreateProductDto createProductDto);

		Task UpdateProductAsync(UpdateProductDto updateProductDto);

		Task DeleteProductAsync(string id);

		Task<GetByIdProductDto> GetByIdProductAsync(string id);

		Task<List<ResultProductsWithCategoryDto>> GetProductsWithCategoryAsync();

	}
}
