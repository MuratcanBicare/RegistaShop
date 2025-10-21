using RegistaShop.DtoLayer.CatalogDtos.ProductDetailDtos;

namespace RegistaShop.WebUI.Services.CatalogServices.ProductDetailServices
{
	public interface IProductDetailService
	{
		Task<List<ResultProductDetailDto>> GetAllProductDetailAsync();
		Task CreateProductDetailAsync(CreateProductDetailDto createProductDetailDto);
		Task UpdateProductDetailAsync(UpdateProductDetailDto updateProductDetailDto);
		Task DeleteProductDetailAsync(string id);
		Task<GetByIdProductDetailDto> GetByIdProductDetailAsync(string id);
		Task<GetByIdProductDetailDto> GetByProductIdProductDetailAsync(string id);
	}
}
