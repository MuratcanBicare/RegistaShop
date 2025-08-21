namespace RegistaShop.Basket.Dtos
{
	public record BasketItemDto(
		string ProductId,
		string ProductName,
		int Quantity,
		decimal Price);

}