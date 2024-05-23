namespace RegistaShop.Catalog.Dtos.ProductDetailDtos
{
	public record UpdateProductDetailDto(
		string ProductDetailId,
		string ProductDescription,
		string ProductInfo,
		string ProductId);
}
