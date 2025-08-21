namespace RegistaShop.Catalog.Dtos.ProductImageDtos
{
	public record GetByIdProductImageDto(
		string ProductImageId,
		List<string> ProductImageList,
		string ProductId);
}