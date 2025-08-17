using RegistaShop.Catalog.Dtos.BrandDtos;

namespace RegistaShop.Catalog.Services.BrandServices
{
	public interface IBrandService
	{
		Task<List<ResultBrandDto>> GetAllBrandAsync();

		Task CreateBrandAsync(CreateBrandDto createBrandDto);

		Task UpdateBrandAsync(UpdateBrandDto updateBrandDto);

		Task DeleteBrandAsync(string id);

		Task<GetByIdBrandDto> GetByIdBrandAsync(string id);

	}
}
