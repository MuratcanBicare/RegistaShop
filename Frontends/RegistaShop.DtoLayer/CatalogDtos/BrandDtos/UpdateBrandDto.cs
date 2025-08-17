using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.DtoLayer.CatalogDtos.BrandDtos
{
	public record UpdateBrandDto(
		string BrandId,
		string BrandName,
		string ImageUrl);

}
