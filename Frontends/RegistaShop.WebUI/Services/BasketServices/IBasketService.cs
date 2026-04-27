using RegistaShop.DtoLayer.BasketDtos;

namespace RegistaShop.WebUI.Services.BasketServices
{
	public interface IBasketService
	{

		Task<BasketTotalDto> GetBasket();
		//Task<BasketTotalDto> GetBasketByUserId(string userId);
		Task SaveBasket(BasketTotalDto basketTotalDto);
		Task DeleteBasket(string userId);
		Task AddBasketItem(BasketItemDto basketItemDto);
		Task<bool> RemoveBasketItem(string productId);

	}
}
