using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.DtoLayer.DiscountDtos
{
	public record GetDiscountCodeDetailByCode(
		int CouponId,
		string Code,
		int Rate,
		bool IsActive,
		DateTime ValidDate);
}
