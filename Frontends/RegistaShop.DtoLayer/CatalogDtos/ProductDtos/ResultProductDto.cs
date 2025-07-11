using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.DtoLayer.CatalogDtos.ProductDtos
{
	public record ResultProductDto(
		string ProductId,
		string ProductName,
		decimal ProductPrice,
		string ProductImageUrl,
		string ProductDescription,
		string CategoryId);

}
