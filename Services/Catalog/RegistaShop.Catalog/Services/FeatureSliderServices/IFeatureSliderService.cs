using RegistaShop.Catalog.Dtos.FeatureSliderDtos;

namespace RegistaShop.Catalog.Services.FeatureSliderServices
{
	public interface IFeatureSliderService
	{

		Task <List<ResultFeatureSliderDto>> GetAllFeatureSliderAsync();
		Task CreateFeatureSliderAsync(CreateFeatureSliderDto createFeatureSliderDto);
		Task UpdateFeatureSliderAsync(UpdateFeatureSliderDto updateFeatureSliderDto);
		Task DeleteFeatureSliderAsync(string id);
		Task<GetByIdFeatureSliderDto> GetByIdFeatureSliderByIdAsync(string id);
		Task FeatureSliderChangeStatusToTrue(string id);
		Task FeatureSliderChangeStatusToFalse(string id);

	}
}
