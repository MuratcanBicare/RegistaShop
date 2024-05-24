namespace RegistaShop.Discount.Dtos
{
	public record CreateDiscountCouponDto(
		string Code,
		int Rate,
		bool IsActive,
		DateTime ValidDate);
}
