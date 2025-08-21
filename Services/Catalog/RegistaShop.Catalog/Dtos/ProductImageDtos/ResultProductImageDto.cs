namespace RegistaShop.Catalog.Dtos.ProductImageDtos
{
	public record ResultProductImageDto(
		string ProductImageId,
		List<string> ProductImageList,
		string ProductId);
}