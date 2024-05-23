namespace RegistaShop.Catalog.Dtos.ProductImageDtos
{
	public record UpdateProductImageDto(
		string ProductImageId,
		string Image1,
		string Image2,
		string Image3,
		string ProductId);
}
