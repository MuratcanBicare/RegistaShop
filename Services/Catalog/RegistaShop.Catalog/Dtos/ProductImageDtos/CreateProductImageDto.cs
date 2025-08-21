namespace RegistaShop.Catalog.Dtos.ProductImageDtos
{
	public record CreateProductImageDto(
		List<string> ProductImageList,
		string ProductId);
}