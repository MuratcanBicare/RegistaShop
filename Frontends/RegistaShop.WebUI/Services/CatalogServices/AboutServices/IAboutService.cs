using RegistaShop.DtoLayer.CatalogDtos.AboutDtos;

namespace RegistaShop.WebUI.Services.CatalogServices.AboutServices
{
	public interface IAboutService
	{
		Task<List<ResultAboutDto>> GetAllAboutAsync();
		Task CreateAboutAsync(CreateAboutDto createAboutDto);
		Task UpdateAboutAsync(UpdateAboutDto updateAboutDto);
		Task DeleteAboutAsync(string id);
		Task<UpdateAboutDto> GetByIdAboutAsync(string id);
	}
}
