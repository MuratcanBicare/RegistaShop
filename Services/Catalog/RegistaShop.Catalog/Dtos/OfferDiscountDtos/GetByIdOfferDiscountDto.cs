namespace RegistaShop.Catalog.Dtos.OfferDiscountDtos
{
	public record GetByIdOfferDiscountDto(
		string OfferDiscountId,
		string Title,
		string SubTitle,
		string ImageUrl,
		string ButtonTitle);

}
