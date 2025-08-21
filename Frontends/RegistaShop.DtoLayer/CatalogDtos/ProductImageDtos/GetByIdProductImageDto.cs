using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.DtoLayer.CatalogDtos.ProductImageDtos
{
	public record GetByIdProductImageDto(
		string ProductImageId,
		List<string> ProductImageList,
		string ProductId);
}
