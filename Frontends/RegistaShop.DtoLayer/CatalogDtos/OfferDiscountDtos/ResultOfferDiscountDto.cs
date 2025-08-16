using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.DtoLayer.CatalogDtos.OfferDiscountDtos
{
	public record ResultOfferDiscountDto(
		string OfferDiscountId,
		string Title,
		string SubTitle,
		string ImageUrl,
		string ButtonTitle);

}
