namespace RegistaShop.Catalog.Dtos.OfferDiscountDtos
{
	public record UpdateOfferDiscountDto(
		string OfferDiscountId,
		string Title,
		string SubTitle,
		string ImageUrl,
		string ButtonTitle);

}
