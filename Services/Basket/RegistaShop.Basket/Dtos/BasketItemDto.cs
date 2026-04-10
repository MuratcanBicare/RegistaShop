namespace RegistaShop.Basket.Dtos
{
	public record BasketItemDto(
		string ProductId,
		string ProductName,
		string ProductImageUrl,
		int Quantity,
		decimal Price);

}