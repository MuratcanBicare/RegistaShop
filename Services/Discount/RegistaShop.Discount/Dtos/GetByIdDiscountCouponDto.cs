namespace RegistaShop.Discount.Dtos
{
	public record GetByIdDiscountCouponDto(
		int CouponId,
		string Code,
		int Rate,
		bool IsActive,
		DateTime ValidDate);
}
