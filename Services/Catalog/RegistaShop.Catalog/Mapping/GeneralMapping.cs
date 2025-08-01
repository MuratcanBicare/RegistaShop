﻿using AutoMapper;
using RegistaShop.Catalog.Dtos.CategoryDtos;
using RegistaShop.Catalog.Dtos.FeatureSliderDtos;
using RegistaShop.Catalog.Dtos.ProductDetailDtos;
using RegistaShop.Catalog.Dtos.ProductDtos;
using RegistaShop.Catalog.Dtos.ProductImageDtos;
using RegistaShop.Catalog.Dtos.SpecialOfferDtos;
using RegistaShop.Catalog.Entities;

namespace RegistaShop.Catalog.Mapping
{
	public class GeneralMapping : Profile
	{

		public GeneralMapping()
		{

			CreateMap<Category, ResultCategoryDto>().ReverseMap();
			CreateMap<Category, CreateCategoryDto>().ReverseMap();
			CreateMap<Category, UpdateCategoryDto>().ReverseMap();
			CreateMap<Category, GetByIdCategoryDto>().ReverseMap();

			CreateMap<Product, ResultProductDto>().ReverseMap();
			CreateMap<Product, CreateProductDto>().ReverseMap();
			CreateMap<Product, UpdateProductDto>().ReverseMap();
			CreateMap<Product, GetByIdProductDto>().ReverseMap();

			CreateMap<ProductDetail, ResultProductDetailDto>().ReverseMap();
			CreateMap<ProductDetail, CreateProductDetailDto>().ReverseMap();
			CreateMap<ProductDetail, UpdateProductDetailDto>().ReverseMap();
			CreateMap<ProductDetail, GetByIdProductDetailDto>().ReverseMap();

			CreateMap<ProductImage, ResultProductImageDto>().ReverseMap();
			CreateMap<ProductImage, CreateProductImageDto>().ReverseMap();
			CreateMap<ProductImage, UpdateProductImageDto>().ReverseMap();
			CreateMap<ProductImage, GetByIdProductImageDto>().ReverseMap();

			CreateMap<Product, ResultProductsWithCategoryDto>().ReverseMap();

			CreateMap<FeatureSlider, ResultFeatureSliderDto>().ReverseMap();
			CreateMap<FeatureSlider, CreateFeatureSliderDto>().ReverseMap();
			CreateMap<FeatureSlider, UpdateFeatureSliderDto>().ReverseMap();
			CreateMap<FeatureSlider, GetByIdFeatureSliderDto>().ReverseMap();

			CreateMap<SpecialOffer, ResultSpecialOfferDto>().ReverseMap();
			CreateMap<SpecialOffer, CreateSpecialOfferDto>().ReverseMap();
			CreateMap<SpecialOffer, UpdateSpecialOfferDto>().ReverseMap();
			CreateMap<SpecialOffer, GetByIdSpecialOfferDto>().ReverseMap();

		}


	}
}
