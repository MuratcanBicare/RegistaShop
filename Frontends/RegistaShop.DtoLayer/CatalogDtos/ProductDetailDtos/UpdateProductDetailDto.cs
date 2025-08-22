using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.DtoLayer.CatalogDtos.ProductDetailDtos
{
	public record UpdateProductDetailDto(
		string ProductDetailId,
		string ProductDescription,
		string ProductInfo,
		string ProductId);

}
