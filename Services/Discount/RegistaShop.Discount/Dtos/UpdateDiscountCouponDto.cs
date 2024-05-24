namespace RegistaShop.Discount.Dtos
{
	public record UpdateDiscountCouponDto(
		int CouponId,
		string Code,
		int Rate,
		bool IsActive,
		DateTime ValidDate);
}
