namespace RegistaShop.Catalog.Dtos.CategoryDtos
{
	public record UpdateCategoryDto(
		string CategoryId,
		string CategoryName,
		string ImageUrl);
}
