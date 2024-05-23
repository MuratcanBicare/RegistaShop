namespace RegistaShop.Catalog.Dtos.ProductDtos
{
    public record CreateProductDto(
        string ProductName,
        decimal ProductPrice,
        string ProductImageUrl,
        string ProductDescription,
        string CategoryId);
}
