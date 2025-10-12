using RegistaShop.DtoLayer.CatalogDtos.FeatureDtos;

namespace RegistaShop.WebUI.Services.CatalogServices.FeatureServices
{
	public interface IFeatureService
	{
		Task<List<ResultFeatureDto>> GetAllFeatureAsync();
		Task CreateFeatureAsync(CreateFeatureDto createFeatureDto);
		Task UpdateFeatureAsync(UpdateFeatureDto updateFeatureDto);
		Task DeleteFeatureAsync(string id);
		Task<UpdateFeatureDto> GetByIdFeatureAsync(string id);
	}
}
