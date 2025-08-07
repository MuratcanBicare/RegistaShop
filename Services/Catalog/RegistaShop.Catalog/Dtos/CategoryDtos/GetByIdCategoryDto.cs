namespace RegistaShop.Catalog.Dtos.CategoryDtos
{
	public record GetByIdCategoryDto(
		string CategoryId,
		string CategoryName,
		string ImageUrl);
}
