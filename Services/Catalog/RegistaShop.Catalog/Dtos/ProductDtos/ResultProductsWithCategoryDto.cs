using RegistaShop.Catalog.Dtos.CategoryDtos;

namespace RegistaShop.Catalog.Dtos.ProductDtos
{
	public record ResultProductsWithCategoryDto(
		string ProductId,
		string ProductName,
		decimal ProductPrice,
		string ProductImageUrl,
		string ProductDescription,
		string CategoryId,
		ResultCategoryDto Category);
}
