namespace RegistaShop.Catalog.Dtos.FeatureSliderDtos
{

	public record UpdateFeatureSliderDto(
		string FeatureSliderId,
		string Title,
		string Description,
		string ImageUrl,
		bool Status);

}