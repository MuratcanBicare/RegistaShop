namespace RegistaShop.Catalog.Dtos.FeatureSliderDtos
{
	public record GetByIdFeatureSliderDto(
		string FeatureSliderId,
		string Title,
		string Description,
		string ImageUrl,
		bool Status);

}