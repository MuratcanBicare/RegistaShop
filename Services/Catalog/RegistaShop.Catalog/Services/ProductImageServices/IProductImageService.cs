﻿using RegistaShop.Catalog.Dtos.ProductImageDtos;

namespace RegistaShop.Catalog.Services.ProductImageServices
{
	public interface IProductImageService
	{

		Task<List<ResultProductImageDto>> GetAllProductImageAsync();

		Task CreateProductImageAsync(CreateProductImageDto createProductImageDto);

		Task UpdateProductImageAsync(UpdateProductImageDto updateProductImageDto);

		Task DeleteProductImageAsync(string id);

		Task<GetByIdProductImageDto> GetByIdProductImageAsync(string id);



	}
}
