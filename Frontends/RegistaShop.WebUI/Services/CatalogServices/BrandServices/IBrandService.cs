using RegistaShop.DtoLayer.CatalogDtos.BrandDtos;

namespace RegistaShop.WebUI.Services.CatalogServices.BrandServices
{
	public interface IBrandService
	{
		Task<List<ResultBrandDto>> GetAllBrandAsync();
		Task CreateBrandAsync(CreateBrandDto createBrandDto);
		Task UpdateBrandAsync(UpdateBrandDto updateBrandDto);
		Task DeleteBrandAsync(string id);
		Task<UpdateBrandDto> GetBrandByIdAsync(string id);
	}
}