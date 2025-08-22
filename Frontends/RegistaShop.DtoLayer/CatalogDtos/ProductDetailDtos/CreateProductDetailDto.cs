using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.DtoLayer.CatalogDtos.ProductDetailDtos
{
	public record CreateProductDetailDto(
		string ProductDescription,
		string ProductInfo,
		string ProductId);

}
