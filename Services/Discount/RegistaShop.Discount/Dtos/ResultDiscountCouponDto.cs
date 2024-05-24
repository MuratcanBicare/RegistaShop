namespace RegistaShop.Discount.Dtos
{
	public record ResultDiscountCouponDto(
		int CouponId,
		string Code,
		int Rate,
		bool IsActive,
		DateTime ValidDate);

}
