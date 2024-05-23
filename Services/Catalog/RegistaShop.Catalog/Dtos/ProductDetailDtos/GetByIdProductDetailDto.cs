namespace RegistaShop.Catalog.Dtos.ProductDetailDtos
{
	public record GetByIdProductDetailDto(
		string ProductDetailId,
		string ProductDescription,
		string ProductInfo,
		string ProductId);
}
