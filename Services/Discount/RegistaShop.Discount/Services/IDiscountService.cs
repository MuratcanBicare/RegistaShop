using RegistaShop.Discount.Dtos;

namespace RegistaShop.Discount.Services
{
	public interface IDiscountService
	{

		Task<List<ResultDiscountCouponDto>> GetAllDiscountCouponAsync();
		Task CreateDiscountCouponAysnc(CreateDiscountCouponDto createCouponDto);
		Task UpdateDiscountCouponAysnc(UpdateDiscountCouponDto updateCouponDto);
		Task DeleteDiscountCouponAysnc(int id);
		Task<GetByIdDiscountCouponDto> GetByIdDiscountCouponAsync(int id);

	}
}
