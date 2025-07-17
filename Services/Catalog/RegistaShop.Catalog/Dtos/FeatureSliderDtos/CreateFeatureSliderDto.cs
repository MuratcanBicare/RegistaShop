namespace RegistaShop.Catalog.Dtos.FeatureSliderDtos
{

	public record CreateFeatureSliderDto(
		string Title,
		string Description,
		string ImageUrl,
		bool Status);

}