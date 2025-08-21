namespace RegistaShop.Catalog.Dtos.ProductImageDtos
{
	public record UpdateProductImageDto(
		string ProductImageId,
		List<string> ProductImageList,
		string ProductId);
}
