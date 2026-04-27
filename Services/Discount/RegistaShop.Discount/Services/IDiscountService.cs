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
		Task<ResultDiscountCouponDto> GetCodeDetailByCodeAsync(string code);
		int GetDiscountCouponRate(string code);

	}
}
