﻿using RegistaShop.Catalog.Dtos.SpecialOfferDtos;

namespace RegistaShop.Catalog.Services.SpecialOfferServices
{
	public interface ISpecialOfferService
	{

		Task<List<ResultSpecialOfferDto>> GetAllSpecialOfferAsync();
		Task CreateSpecialOfferAsync(CreateSpecialOfferDto createSpecialOfferDto);
		Task UpdateSpecialOfferAsync(UpdateSpecialOfferDto updateSpecialOfferDto);
		Task DeleteSpecialOfferAsync(string id);
		Task<GetByIdSpecialOfferDto> GetByIdSpecialOfferAsync(string id);

	}
}
