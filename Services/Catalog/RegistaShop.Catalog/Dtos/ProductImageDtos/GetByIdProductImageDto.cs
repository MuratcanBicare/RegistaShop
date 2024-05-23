namespace RegistaShop.Catalog.Dtos.ProductImageDtos
{
	public record GetByIdProductImageDto(
		string ProductImageId,
		string Image1,
		string Image2,
		string Image3,
		string ProductId);
}
