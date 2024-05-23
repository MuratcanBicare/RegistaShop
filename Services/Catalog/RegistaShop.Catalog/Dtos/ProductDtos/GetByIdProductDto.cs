namespace RegistaShop.Catalog.Dtos.ProductDtos
{
    public record GetByIdProductDto(
        string ProductId,
        string ProductName,
        decimal ProductPrice,
        string ProductImageUrl,
        string ProductDescription,
        string CategoryId);
}
