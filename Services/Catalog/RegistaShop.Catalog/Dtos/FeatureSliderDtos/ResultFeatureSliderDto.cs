namespace RegistaShop.Catalog.Dtos.FeatureSliderDtos
{

	public record ResultFeatureSliderDto(
		string FeatureSliderId,
		string Title,
		string Description,
		string ImageUrl,
		bool Status);

}