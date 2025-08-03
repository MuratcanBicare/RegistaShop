using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.DtoLayer.CatalogDtos.SpecialOfferDtos
{
	public record CreateSpecialOfferDto(
		string Title,
		string SubTitle,
		string ImageUrl);
}
